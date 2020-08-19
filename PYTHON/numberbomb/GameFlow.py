class GameRule:
    def __init__(self):
        super().__init__()
        self.range = [0,1]
        self.luckNum = 0

    def __init__(self, luckNum:int):
        super().__init__()
        self.range = [0,1]
        self.luckNum = luckNum

class PreGame:
    def __init__(self):
        super().__init__()
    
    def gameModeSelector(self,mode:int):
        diff = {1: 100, 2: 250, 3: 500}
        return diff.get(mode, False)

    
