import requests
from bs4 import BeautifulSoup
import csv

# Website URL
url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

# Request the webpage
response = requests.get(url)

# Parse HTML
soup = BeautifulSoup(response.text, "html.parser")

# Find all books
books = soup.find_all("article", class_="product_pod")

# List to store data
book_data = []

for book in books:
    # Get book title
    title = book.h3.a["title"]

    # Get price
    price = book.find("p", class_="price_color").text

    # Get rating
    rating = book.p["class"][1]

    # Store data
    book_data.append([title, rating, price])

# Save to CSV
with open("books.csv", "w", newline="", encoding="utf-8") as file:
    writer = csv.writer(file)

    # Header
    writer.writerow(["Title", "Rating", "Price"])

    # Write book data
    writer.writerows(book_data)

print("Book data saved to books.csv\n")

# Read the CSV file and display data
print("Displaying data from CSV:\n")

with open("books.csv", "r", encoding="utf-8") as file:
    reader = csv.reader(file)

    for row in reader:
        print(row)