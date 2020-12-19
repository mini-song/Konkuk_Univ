import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.naive_bayes import GaussianNB
from sklearn.metrics import accuracy_score
df=pd.read_csv('./data_week12.csv')
Y=df['Class variable (0 or 1).']
X=df[['Number of times pregnant.','Plasma glucose concentration a 2 hours in an oral glucose tolerance test.','Diastolic blood pressure (mm Hg).','Triceps skinfold thickness (mm).','2-Hour serum insulin (mu U/ml).','Body mass index (weight in kg/(height in m)^2).','Diabetes pedigree function.','Age (years).']]
X_train, X_test, Y_train, Y_test = train_test_split(X, Y, test_size=0.3)
model = GaussianNB()
model.fit(X_train,Y_train)
accuracy = model.score(X_test,Y_test)*100
print(accuracy,"%")

