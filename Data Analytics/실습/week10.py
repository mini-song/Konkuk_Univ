import tomotopy as tp
mdl = tp.LDAModel(k=3)
for line in open('C:\\Users\\minisong\\Desktop\\data_week10.txt'):
    mdl.add_doc(line.strip().split())
for i in range(100):
    mdl.train()
    #print('Iteration: {}\tLog-likelihood: {}'.format(i, mdl.ll_per_word))
for k in range(mdl.k):
    print('Top 2 words of topic #{}'.format(k))
    print(mdl.get_topic_words(k, top_n=7))


