#include<iostream>
using namespace std;
int main()
{
	int arr[10][10], arrr[10][10], mul[10][10];
	int row1, row2, col1, col2;
	cout << "ENTER THE NUMBER OF ROWS OF FIRST MATRIX :";
	cin >> row1;
	cout << "ENTER THE NUMBER OF COLUMNS OF FIRST MATRIX :";
	cin >> col1;
	cout << "ENTER THE VALUES OF FIRST MATRIX :"<<endl;
	for (int i = 0; i < row1; i++)
	{
		for (int j = 0; j < col1; j++)
		{
			cin >> arr[i][j];
		}
	}
	for (int i = 0; i < row1; i++)
	{
		for (int j = 0; j < col1; j++)
		{
			cout << arr[i][j] << " ";
		}
		cout << endl;
	}

	cout << "ENTER THE NUMBER OF ROWS OF SECOND MATRIX :";
	cin >> row2;
	cout << "ENTER THE NUMBER OF COLUMNS OF SECOND MATRIX :";
	cin >> col2;
	cout << "ENTER THE VALUE OF SECOND MATRIX :"<<endl;
	for (int i = 0; i < row2; i++)
	{
		for (int j = 0; j < col2; j++)
		{
			cin >> arrr[i][j];
		}
	}
	for (int i = 0; i < row2; i++)
	{
		for (int j = 0; j < col2; j++)
		{
			cout << arrr[i][j] << " ";
		}
		cout << endl;
	}
	{
		if (col1 != row2)
		{
			cout << "THEY CANNOT BE MULTIPLIED.";

		}
		//for multiplying the matrix.
		else
		{
			cout << "THEY CAN BE MULTIPLY." << endl;
			for (int i = 0; i < row1; i++)
			{
				for (int j = 0; j < col2; j++)
				{
					mul[i][j] = 0;
					for (int k = 0; k < col2; k++)
					{
						mul[i][j] += arr[i][k] * arrr[k][j];
					}
				}
			}
			//for displaying the multiplicated values.
			for (int i = 0; i < row1; i++)
			{
				for (int j = 0; j < col2; j++)
				{
					cout << mul[i][j] << " ";
				}
				cout << "\n";
			}
			system("pause");
			return 0;
		}
	}
	system("pause>0");
}
