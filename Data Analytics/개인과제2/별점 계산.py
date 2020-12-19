import csv
import pandas as pd
import numpy as np
dataset=[]
f = open('./data_review.csv','r',encoding='utf-8')
rdr = csv.reader(f)
for i in rdr:
    dataset.append(i)
맛=[]
양=[]
배달=[]
for i in dataset:
    if not i[3]== '':
        맛.append(i[3])
    if not i[4]== '':
        양.append(i[4])
    if not i[5]== '':
        배달.append(i[5])
del 맛[0]
del 양[0]
del 배달[0]
맛_자료= np.array(맛).astype(np.float)
양_자료= np.array(양).astype(np.float)
배달_자료= np.array(배달).astype(np.float)

print( "맛 평균:", round(np.mean(맛_자료),3),"맛 표준 편차:",round(np.std(맛_자료),3),"3시그마:",round(round(np.mean(맛_자료),3)-3*round(np.std(맛_자료),3),2))
print( "양 평균:", round(np.mean(양_자료),3),"양 표준 편차:",round(np.std(양_자료),3),"3시그마:",round(round(np.mean(양_자료),3)-3*round(np.std(양_자료),3),2))
print( "배달 평균:", round(np.mean(배달_자료),3),"배달 표준 편차:",round(np.std(배달_자료),3),"3시그마:",round(round(np.mean(배달_자료),3)-3*round(np.std(배달_자료),3),2))



