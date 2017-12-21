class Human(object):
    laugh="hahaha"
    def show_laugh(self):
        print(self.laugh)
    def laugh_100th(self):
        for i in range(100):
            self.show_laugh()
Jack=Human()
Jack.laugh_100th()