def biggestNo (first_Number,second_Number,third_Number):
    if (first_Number > second_Number) and (first_Number > third_Number):
        return first_Number
    elif (second_Number > first_Number) and (second_Number > third_Number):
        return second_Number
    else:
        return third_Number
first = int(input("Enter first number : "))
second = int(input("Enter second number : "))
third = int(input("Enter third number : "))
largest = biggestNo(first,second,third)
print("The largest of",first,",",second,",",third,"is",largest)