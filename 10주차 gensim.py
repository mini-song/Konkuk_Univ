import gensim
import gensim.corpora as corpora
documents =[]
with open('C:\\Users\\minisong\\Desktop\\data_week10.txt','r') as f:
    list_file = f.readlines()
documents = [line.rstrip('\n') for line in list_file] 
f.readline
stoplist=[]
texts = [[word for word in document.lower().split() if word not in stoplist] for document in documents]
dictionary = corpora.Dictionary(texts)
corpus = [dictionary.doc2bow(text) for text in texts]
lda = gensim.models.ldamodel.LdaModel(corpus=corpus, id2word=dictionary, num_topics=3, update_every=1, chunksize=100, passes=10)
result=lda.print_topics(num_words=7)
for i in result:
    print(i)
