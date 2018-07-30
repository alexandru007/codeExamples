import random

age = 0

#  Questions and answers dictionary
question_dict = {
        "If I have 10 candy bars and I give you 4, how many I have" : "6",
        "If you mix blue with yellow, what color you get" : "green",
        "If I am on one side of a lake and you are on the other side, what can I use to cross the lake?" : "boat",
        "You have a cookie and your Mom says you have to break it in two equal pieces and share it. What do you call those two equal pieces?" : "halves",
        "A number that is bigger than 13 and smaller than 15" : "14",
        "Where do oranges grow?" : "tree"
                 }

def question_and_answers():
    playing = True
    while playing:

        #  Set the score to 0
        score = 0

        #  To choose the number of questions
        num = int(raw_input('how many questions you would like to answer: '))

        #  Loop number of times equal to number of questions
        for i in range(num):
            question = (random.choice(list(question_dict.keys())))
            answer = question_dict[question]

            #  print the Q and questuin number
            print "Question nr.{0}:".format(i+1)
            print question
            guess = raw_input('Your answer: ')

            #  check if the answer is correct
            if guess.lower() == answer:
                print "Corect!!!"
                score += 1
            else:
                print "Wrong answer, sorry"

        #  final score
        print "Your final score is " + str(score)

        #  To play again or to quit
        again = raw_input("Enter any key to play again, or press 'q' to quit: ")
        if again == 'q':
            playing = False

def math():
    print 'Math test'
    num1 = random.randint(10, 80)
    num2 = random.randint(10, 80)
    print 'How much is {0} + {1}'.format(num1, num2)
    no_num = 0
    while True:
        answer = raw_input('Enter your answer please:')
        no_num += 1
        if answer.isdigit():
            break
        elif no_num == 3:
            print "Game over"
            return None
        else:
            print "Numbers only. Try again"

    if int(answer) == num1 + num2:
        print 'Correct!!!'
    else:
        print 'Wrong answer'
        
def logic():
    print 'Logic test'
    print 'If you are a pilot of a plane and the plane flys 1000 mph what is the age of the pilot'
    while True: 
        answer = raw_input('Guess the age of the pilot:')
        if answer.isdigit():
            break
        else:
            print 'Numbers only. Try again' 
    if answer == age:
        print 'Correct!!!'
    else:
        print "{0}, {1}".format("Wrong, correct answer is", age)

def welcome():
    '''To store name and age'''
    print '----Hello----'
    print 'What is your name?'
    name = raw_input('')
    print 'How old are you?'

    #  age validation
    while True:
        global age
        age = raw_input()
        if age.isdigit():
            break
        else:
            print 'Numbers only'
    print 'OK, Great'

if __name__ == "__main__":
    welcome()
    math()
    logic()
    question_and_answers()
