import pandas as pd
pd.options.mode.chained_assignment = None
 
import numpy as np
np.random.seed(0)
 
from konlpy.tag import Twitter
twitter = Twitter()

import json

from sklearn.feature_extraction.text import TfidfVectorizer, CountVectorizer
from sklearn.metrics.pairwise import linear_kernel, cosine_similarity

import re
import numpy as np
from nltk.corpus import stopwords

import csv
 
def tokenizer(raw, pos=["Noun","Alpha","Verb","Number"], stopword=[]):
    return [
        word for word, tag in twitter.pos(
            raw, 
            norm=True,  
            stem=True    
            )
            if len(word) > 1 and tag in pos and word not in stopword
        ]
with open("C:\\Users\\minisong\\Desktop\\data_week8.json", 'r', encoding ='utf-8') as f:

    json_data = json.load(f)
stop_words = set(stopwords.words('english'))
aaa = []
listlsit=""
rawdata = []
for i in json_data:
    aa=[]
    a=[]
    a= re.sub('[^a-zA-Z]', ' ', i['review_body'])
    a.lower()
    middle=""
    aa=a.split(" ")
    for w in aa:
        if w  not in stop_words: 
            middle = middle + w + " " 
    rawdata.append(middle)
vectorize = CountVectorizer(
    tokenizer=tokenizer, 
    min_df=25
)

X = vectorize.fit_transform(rawdata)
 
print('fit_transform, (sentence {}, feature {})'.format(X.shape[0], X.shape[1]))
 

print(X.toarray())

features = vectorize.get_feature_names()
print(features)

a = np.array(X.toarray())
df = pd.DataFrame(np.dot(a.T,a))
df.to_csv("결과데이터 degree.csv",encoding="utf-8-sig",header = False, index = False)