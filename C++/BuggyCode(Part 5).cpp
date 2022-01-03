std::vector<int> printArray(int n){
  std::vector<int> newArray;
  
  for(int i = 1; i <= n;){
    newArray.push_back(i);
  }
  
  return newArray;
}
