import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import numpy as np
df=pd.read_csv('./data_week12.csv')
#sns.countplot(x='Class variable (0 or 1).', data=df)
#plt.show()
from sklearn.linear_model import LogisticRegression
from sklearn.model_selection import train_test_split
Y=df['Class variable (0 or 1).']
X=df[['Number of times pregnant.','Plasma glucose concentration a 2 hours in an oral glucose tolerance test.','Diastolic blood pressure (mm Hg).','Triceps skinfold thickness (mm).','2-Hour serum insulin (mu U/ml).','Body mass index (weight in kg/(height in m)^2).','Diabetes pedigree function.','Age (years).']]
X_train, X_test, Y_train, Y_test = train_test_split(X, Y, test_size=0.3)
log_clf = LogisticRegression()
log_clf.fit(X_train,Y_train)
print(log_clf.score(X_test, Y_test)*100,"%")
