# Sessions are how web servers remembers information about each user, which enables features like allowing users to stay logged in, and saving items to a shopping cart.
# These features require our server to be stateful, or having access to additional state, or information.
# HTTP on its own is stateless, since after we make a request and get a response, the interaction is completed.
# It turns out that servers can send another header in a response, called Set-Cookie:
# Cookies are small pieces of data from a web server that the browser saves for us.
# In many cases, they are large random numbers or strings used to uniquely identify and track a user between visits.
# In this case, the server is asking our browser to set a cookie for that server, called session to a value of value.
# Then, when the browser makes another request to the same server, it’ll send back the same cookie that the same server has set before:
# Demonstrates the use of session to stamp every user who visits this page vertually and creates the illusion of per user storage

from flask import Flask, redirect, render_template, request, session
from flask_session import Session

# Configure app

app = Flask(__name__)

# Configure session

app.config["SESSION_PERMANENT"] = False
app.config["SESSION_TYPE"] = "filesystem"
Session(app)

@app.route("/")
def index():
    if not session.get("name"):
        return redirect("/login")
    return render_template("index.html")


@app.route("/login",methods=["GET", "POST"])
def login():
    if request.method == "POST":
        session["name"] = request.form.get("name")
        return redirect("/")
    return render_template("login.html")

@app.route("/logout")
def logout():
    session["name"] = None
    return redirect("/")


