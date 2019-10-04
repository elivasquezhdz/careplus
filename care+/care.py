from flask import Flask, render_template, url_for
from flask_ngrok import run_with_ngrok
app = Flask(__name__)
run_with_ngrok(app)

@app.route("/")
@app.route("/home")
def home():
    return render_template('home.html')
    
@app.route("/details")
def about():
    return render_template('details.html', title='Account Details')

@app.route("/video")
def video():
    return render_template('video.html', title='Account Details')

if __name__ == '__main__':
    app.run()
    #app.run(debug=True,host='0.0.0.0')
