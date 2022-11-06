#include <iostream>
#include <vector>
#include <string>
#include <numeric>

using namespace std;

int FindMissing(const vector<int>& input) {
	// Calculate sum of all elements in the input vector
	// The accumulate function can this for us
	int actual_sum = accumulate(input.begin(), input.end(), 0);
	int n = input.size();

	// Find the sum of first n numbers using the arithmetic series sum formula,
	// i.e.,​ ​(n∗(n+1))/2
	int sum_of_n = (n * (n + 1)) / 2;

	// The difference between sum_of_n and actual_sum, is the missing number in the
	// array
	return sum_of_n - actual_sum;
}

int main() {
	vector<vector<int> > vec_list = {{0}, {3, 7, 1, 2, 0, 4, 5}, {9, 6, 4, 2, 3, 5, 7, 0, 1}};
	for (int i = 0; i < vec_list.size(); i++) {
		cout << i + 1 << ". Original ";

		int missing = FindMissing(vec_list[i]);
		cout << "   The missing number is: " << missing << endl;
		cout << "\n------------------------------------------------------------------------------------------------------\n" << endl;
	}
}