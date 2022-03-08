#implements a registration form, storing registrants in a dictionary, with error messages

from flask import Flask, render_template, request, redirect

app = Flask(__name__)

REGISTRANTS = {}

SPORTS = [
    "Soccer",
    "Basketball",
    "Ultimate Frisbee"
]
@app.route("/")
def index():
    return render_template("index.html", sports=SPORTS)

@app.route("/register", methods=["POST"])
def register():

    # validate name
    name = request.form.get("name")
    if not name:
        return render_template("error.html", message="Missing name")
    # validate sport
    sport = request.form.get("sport")
    if not sport:
        return render_template("error.html", message="Missing sport")
    if sport not in SPORTS:
        return render_template("error.html", message="Invalid Sport")

    # remember Registrants
    REGISTRANTS[name] = sport

    # Confirm registration
    return redirect("/registrants")

@app.route("/registrants")
def registrants():
    return render_template("registrants.html",registrants=REGISTRANTS)
