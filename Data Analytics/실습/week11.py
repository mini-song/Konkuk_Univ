import pandas as pd
import numpy as np
import csv
import matplotlib.pyplot as plt
from sklearn.cluster import KMeans
import seaborn as sns
import matplotlib
from sklearn.preprocessing import MinMaxScaler
data= []
f = open('./data_week11.csv','r')
rdr = csv.reader(f)
for i in rdr:
    data.append(i)
del data[0]
scaler = MinMaxScaler(feature_range=(0, 1))
scaler.fit_transform(data)
feature = scaler.fit_transform(data)
'''
def elbow(X):
    sse = []
    for i in range(1,11):
        km = KMeans(n_clusters=i,algorithm='auto', random_state=3000)
        km.fit(X)
        sse.append(km.inertia_)
        
    plt.plot(range(1,11), sse, marker='o')
    plt.xlabel('K')
    plt.ylabel('SSE')
    plt.show()
'''
#elbow(feature)

df = pd.DataFrame(columns =('x','y'))

for i in range(0,len(data)):
    df.loc[i] = [float(data[i][0]),float(data[i][1])]
data_points = df.values
kmeans = KMeans(n_clusters=3).fit(data_points)
kmeans.labels_
df['cluster_id'] = kmeans.labels_
sns.lmplot('x','y',data=df,fit_reg = False, scatter_kws ={"s":1},hue="cluster_id")
plt.show()