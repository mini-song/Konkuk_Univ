import pandas as pd
from mlxtend.preprocessing import TransactionEncoder
from mlxtend.frequent_patterns import apriori
dataset=[]
import csv
f = open('data_week6.txt','r',encoding="utf-8-sig")
rdr = csv.reader(f)
for i in rdr:
    dataset.append(i)
print(dataset)
te = TransactionEncoder()
te_ary = te.fit(dataset).transform(dataset)
df = pd.DataFrame(te_ary, columns=te.columns_)
frequent_itemsets = apriori(df, min_support=0.1, use_colnames=True)

from mlxtend.frequent_patterns import association_rules
association_rules(frequent_itemsets, metric="confidence", min_threshold=0.3).to_csv("./결과데이터.csv", encoding='ms949')



