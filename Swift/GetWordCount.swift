func countWords(_ str: String) -> Int {
	let components = str.components(separatedBy: .whitespacesAndNewlines)
  let words = components.filter { !$0.isEmpty }
  return words.count
}
