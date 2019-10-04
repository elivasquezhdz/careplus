import os
from flask import  jsonify, request, Flask
#from check_utils import check_solder
import pandas as pd
HEADERSIZE = 10

data = pd.read_csv("members.csv",sep="|")

@app.route('/query', methods=['POST','GET','PUT'])
def query():
    return data

if __name__ == '__main__':
    app.run(host="0.0.0.0")