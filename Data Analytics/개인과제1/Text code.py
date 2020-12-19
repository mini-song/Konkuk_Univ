import csv
import pandas as pd
from tqdm import tqdm
from sklearn.feature_extraction.text import CountVectorizer
import scipy
import nltk
pd.options.mode.chained_assignment = None
import numpy as np
np.random.seed(0)
from konlpy.tag import Twitter
twitter = Twitter()
from sklearn.feature_extraction.text import TfidfVectorizer, CountVectorizer
from sklearn.metrics.pairwise import linear_kernel, cosine_similarity
import re
from nltk.corpus import stopwords
title=[]
f = open('./특허제목추출.csv','r',encoding='utf-8')
rdr = csv.reader(f)
for i in rdr:
    title.append(i)
title.pop(0)
rawdata=[]
f = open('./정제된 ipc.csv','r',encoding='utf-8')
rdr = csv.reader(f)
for i in rdr:
    rawdata.append(i)
sp=[0,0]
new=[]
for i in tqdm(range(0,len(rawdata))):
    for j in range(1,len(rawdata[i])):
        if rawdata[i][j][0:3] =="H04":
            sp[0] = 1
        if rawdata[i][j][0:3] =="G06":
            sp[1] = 1
    if sp==[1,1]:
        new.append(title[i][1])
        sp=[0,0]
    else:
        sp=[0,0]
def tokenizer(raw, pos=["Noun","Alpha","Number"], stopword=[]):
    return [
        word for word, tag in twitter.pos(
            raw, 
            norm=True,  
            stem=True    
            )
            if len(word) > 1 and tag in pos and word not in stopword
        ]
stop_words = set(stopwords.words('english'))
aaa = []
listlsit=""
rawdata = []
for i in new:
    aa=[]
    a=[]
    a= re.sub('[^a-zA-Z]', ' ', i)
    a.lower()
    middle=""
    aa=a.split(" ")
    for w in aa:
        if w  not in stop_words: 
            middle = middle + w + " " 
    rawdata.append(middle)
vectorize = CountVectorizer(
    tokenizer=tokenizer, 
    min_df=50
)
X = vectorize.fit_transform(rawdata)
features = vectorize.get_feature_names()
featuress = {}
a = np.array(X.toarray())
df = pd.DataFrame(a)
df.to_csv("Text_code_result2.csv",encoding="utf-8-sig",index = features,header = features)