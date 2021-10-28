
def biggestNo (*no):
    if (no[0] > no[1]) and (no[0] > no[2]):
        return no[0]
    elif (no[1] > no[0]) and (no[1] > no[2]):
        return no[1]
    else:
        return no[2]
first = int(input("Enter first number : "))
second = int(input("Enter second number : "))
third = int(input("Enter third number : "))
largest = biggestNo(first,second,third)
print("The largest of",first,",",second,",",third,"is",largest)




'''
#another method

def biggestNo(*no):
    result = no[0]
    for num in no:
        if num > result:
            result = num
    return result
print(biggestNo(100,44,56))
'''
