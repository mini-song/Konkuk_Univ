import numpy as np
import konlpy
import csv
from tqdm import tqdm
import pandas as pd
from sklearn.feature_extraction.text import TfidfVectorizer, CountVectorizer
from sklearn.linear_model import LogisticRegression
from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score
import gensim
import gensim.corpora as corpora
from matplotlib import pyplot as plt

review_O_data=[]
f = open('./data_review.csv','r',encoding='utf-8') 
rdr = csv.reader(f)
review_O_data_tag = []
review_X_data =[]
f2 = open('./data_review.csv','r',encoding='utf-8')
rdr2 = csv.reader(f2)
select_category=input("야식, 족발/보쌈, 한식, 분식, 일식/돈까스, 피자, 중식, 치킨")
company_list=[]
for j in rdr2:
    if j[1] ==select_category:
        company_list.append(j[0])
print(set(company_list))
select_company = input("위의 목록 또는 전체를 입력해 주세요")
Want_comfortable=input("좋음,보통,나쁨 을 입력하세요")
for i in rdr:
    try:
        if i[1] ==select_category:
            if select_company =='전체':
                if i[3] == '':
                    review_X_data.append(i[6])
                else:
                    if float(i[3])<=2 and float(i[4])<=2 and float(i[5])<=2:
                        review_O_data.append(i[6])
                        review_O_data_tag.append(0) #나쁨
                    elif float(i[3])>=4 and float(i[4])>=4 and float(i[5])>=4:
                        review_O_data.append(i[6])
                        review_O_data_tag.append(1) #좋음
                    else:
                        review_O_data.append(i[6])
                        review_O_data_tag.append(2) #보통
            elif i[0] ==select_company:
                if i[3] == '':
                    review_X_data.append(i[6])
                else:
                    if float(i[3])<=2 and float(i[4])<=2 and float(i[5])<=2:
                        review_O_data.append(i[6])
                        review_O_data_tag.append(0) #나쁨
                    elif float(i[3])>=4 and float(i[4])>=4 and float(i[5])>=4:
                        review_O_data.append(i[6])
                        review_O_data_tag.append(1) #좋음
                    else:
                        review_O_data.append(i[6])
                        review_O_data_tag.append(2) #보통
    except:
        pass
reveiw_Total_data = review_O_data + review_X_data
for i, document in tqdm(enumerate(reveiw_Total_data)):
    okt = konlpy.tag.Okt()
    clean_words = []
    for word in okt.pos(document, stem =True): #Letimazation
        if word[1] in ['Noun', 'Verb']:
            clean_words.append(word[0])
    document = ' '.join(clean_words)
    reveiw_Total_data[i] = document
#result=pd.DataFrame(reveiw_Total_data)

vectorize = CountVectorizer(min_df=10)
X = vectorize.fit_transform(reveiw_Total_data)
features = vectorize.get_feature_names()
Vector_Matrix = np.array(X.toarray())
review_O_data_df = pd.DataFrame(Vector_Matrix)
review_X_data_df = review_O_data_df.iloc[len(review_O_data)+1:,:]
review_X_data_df.to_csv("review_x_data.csv",encoding="utf-8-sig",header = features)
review_O_data_df=review_O_data_df.head(len(review_O_data))
review_O_data_df["태그"] = review_O_data_tag
features.append("태그")
review_O_data_df.to_csv("review_o_data.csv",encoding="utf-8-sig",header = features)
review_O_data_df=pd.read_csv('./review_o_data.csv')
review_X_data_df=pd.read_csv('./review_x_data.csv')
Y=review_O_data_df['태그']
features.pop(-1)
X=review_O_data_df[features]
X_train, X_test, Y_train, Y_test = train_test_split(X, Y, test_size=0.3)
log_clf = LogisticRegression()
log_clf.fit(X_train,Y_train)
print("정확도:",round(log_clf.score(X_test, Y_test)*100,2),"%")
review_X_data_tag = log_clf.predict(review_X_data_df[features])
review_x_tag_df = pd.DataFrame(review_X_data_tag)
review_Total_data_tag = review_O_data_tag+list(np.array(review_x_tag_df[0].tolist()))
final_data = []
spool = []
for i in range(0,len(review_Total_data_tag)):
    spool.append(reveiw_Total_data[i])
    if review_Total_data_tag[i] == 1:
        spool.append('좋음')
    elif review_Total_data_tag[i] == 2:
        spool.append("보통")
    else:
        spool.append("나쁨")
    final_data.append(spool)
    spool = []

lda_list =[]
for i in final_data:
    if i[1] ==Want_comfortable:
        lda_list.append(i[0])
documents =[]
documents = [line.rstrip('\n') for line in lda_list] 
stoplist=["제","걸","번","그것","요","거","온","함","분","하다","임","것","다시다","전","치","뿌","링클"] #결과를 계속 보고 stoplist를 채워준다.
texts = [[word for word in document.lower().split() if word not in stoplist] for document in documents]
dictionary = corpora.Dictionary(texts)
corpus = [dictionary.doc2bow(text) for text in texts]

from gensim.test.utils import common_corpus, common_dictionary
from gensim.models.ldamodel import LdaModel
from gensim.models.coherencemodel import CoherenceModel

x=[]
y=[]
z=[]

for i in tqdm(range(1,40)):
    lda = gensim.models.ldamodel.LdaModel(corpus=corpus, id2word=dictionary,
    num_topics=10, update_every=1, chunksize=100, passes=30)
    result=lda.print_topics(num_words=i)

    cm = CoherenceModel(model=lda, corpus=common_corpus, coherence='u_mass')
    coherence = cm.get_coherence()  
    c=coherence
    p=lda.log_perplexity(corpus)
    x.append(i)
    y.append(c)
    z.append(p)

plt.plot(x,y)
plt.xlabel('num_words')
plt.ylabel('coherence')
plt.show()

plt.plot(x,z)
plt.xlabel('num_words')
plt.ylabel('perplexity')
plt.show()
