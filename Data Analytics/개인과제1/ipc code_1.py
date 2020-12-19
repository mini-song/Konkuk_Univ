import csv
import pandas as pd
from tqdm import tqdm
from sklearn.feature_extraction.text import CountVectorizer
import scipy
import nltk
ipc=[]
f = open('./ipc.csv','r',encoding='utf-8')
rdr = csv.reader(f)
for i in rdr:
    ipc.append(i)
rawdata =[]
mid =[]
a=100
정제=[]
f = open('./정제된 특허등록번호.csv','r')
lines=f.readlines()
#rdr = csv.reader(f)
for i in lines:
    정제.append(i.replace("\n",""))
for i in tqdm(range(0,len(ipc))):
    if ipc[i][0] in 정제:
        
        if ipc[a][0] == ipc[i][0]:
            mid.append(ipc[i][1])            
        else:
            rawdata.append(mid)
            mid =[]
            mid.append(ipc[i][0])
            mid.append(ipc[i][1])
            a=i
rawdata.remove([])
new=[]
for i in range(0,len(rawdata)):
    sia = ""
    for j in range(1,len(rawdata[i])):
        sia= sia + " " + rawdata[i][j][0]
    new.append(sia)
vocabulary = {}
data = []
row = []
col = []
tokenizer = nltk.tokenize.word_tokenize
def create_cooccurrence_matrix(sentences, window_size=2):
    for sentence in sentences:
        sentence = sentence.strip()
        tokens = [token for token in tokenizer(sentence) if token != u""]
        for pos, token in enumerate(tokens):
            i = vocabulary.setdefault(token, len(vocabulary))
            start = max(0, pos-window_size)
            end = min(len(tokens), pos+window_size+1)
            for pos2 in range(start, end):
                if pos2 == pos:
                    continue
                j = vocabulary.setdefault(tokens[pos2], len(vocabulary))
                data.append(1.)
                row.append(i)
                col.append(j)
    cooccurrence_matrix_sparse = scipy.sparse.coo_matrix((data, (row, col)))
    return vocabulary, cooccurrence_matrix_sparse
sentences = new
vocabs,co_occ = create_cooccurrence_matrix(sentences)
df_co_occ  = pd.DataFrame(co_occ.todense(),
                          index=vocabs.keys(),
                          columns = vocabs.keys())
df_co_occ = df_co_occ.sort_index()[sorted(vocabs.keys())]
df_co_occ.to_csv("Co-occurrence.csv", mode='w')
print(df_co_occ)