func total_cups(_ cups: Int) -> Int {
	var promotionBase : Int = 6
	var freeCups: Int = cups/promotionBase
	
	return cups + freeCups
}
