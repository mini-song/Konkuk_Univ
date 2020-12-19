import pandas as pd
import numpy as np
from sklearn.metrics import accuracy_score
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
import os
from sklearn import tree
import graphviz
from sklearn.tree import export_graphviz
os.environ["PATH"] += os.pathsep + 'C:/Program Files (x86)/Graphviz2.38/bin/'

df=pd.read_csv('./data_week13.csv')
Y=df['Species']
X=df[['SepalLength','SepalWidth','PetalLength','PetalWidth']]

clf = tree.DecisionTreeClassifier(criterion='entropy',max_depth=5)
clf = clf.fit(X, Y)
X_train, X_test, Y_train, Y_test = train_test_split(X, Y, test_size=0.3)
clf.fit(X_train,Y_train)
print(round(clf.score(X_test,Y_test),2)*100,"%")

class_names = clf.classes_

export_graphviz(clf,out_file='result.dot',
                class_names= class_names,
                feature_names=['SepalLength','SepalWidth','PetalLength','PetalWidth'],
                impurity=False, filled=True) 

with open('result.dot') as file_reader:
    dot_graph = file_reader.read()
dot = graphviz.Source(dot_graph) 
dot.render(filename='C:\\Users\\minisong\\Desktop\\결과')
