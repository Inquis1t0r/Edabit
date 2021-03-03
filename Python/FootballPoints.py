def football_points(wins, draws, losses):
	winCoeff = 3
	drawCoeff = 1
	lossCoeff  = 0
	return wins * winCoeff + draws * drawCoeff + losses * lossCoeff
