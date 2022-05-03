Class User(object):
    def _init__(self,name,age):
        self.name = name
        self.age = age

        user1 = User("suzuki",26)
        user2 = User("sato",31)

    def say(user):
        print('私の名前は%です。%s歳です。'%(user.name,user.age,))

        user1 = User("suzuki",26)
            user2 = User("sato",31)

            say(user1)
            say(user2)

