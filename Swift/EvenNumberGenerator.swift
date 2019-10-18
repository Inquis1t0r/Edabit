func findEvenNums(_ num: Int) -> [Int] {
	var results:[Int] = []
	
	for temp in 1...num {
		if(temp%2 == 0)
		{
    results.append(temp)
		}
	}
	return results
}
