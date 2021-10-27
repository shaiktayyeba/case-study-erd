def cal(age):
   year=((2021-age)+100)
   return year
name = input("Enter your name: ")
age = int(input("Enter your age: "))
year = cal(age)
print("hi!",name,"Now your age is",age," and you will turn 100 years old in the year", year)
