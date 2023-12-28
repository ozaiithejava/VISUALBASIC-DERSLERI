Dim manager As New PlayerManager()

manager.AddPlayer("Player1", 100)
manager.AddPlayer("Player2", 150)
manager.DisplayPlayerInfo()

manager.UpdatePlayerScore("Player1", 120)
manager.DisplayPlayerInfo()

manager.RemovePlayer("Player2")
manager.DisplayPlayerInfo()
