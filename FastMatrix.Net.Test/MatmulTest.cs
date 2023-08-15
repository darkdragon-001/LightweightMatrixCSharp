namespace FastMatrix.Net.Test;

public class MatmulTest
{
    [Fact]
    public void SmallMatmulTest()
    {
        var id = Matrix.IdentityMatrix(5, 5);
        var rand = Matrix.RandomMatrix(5, 5, 10);
        var result = Matrix.Multiply(rand, id);

        Assert.Equal(rand.rows, result.rows);
        Assert.Equal(rand.cols, result.cols);

        for (int row = 0; row < rand.rows; row++)
            for (int col = 0; col < rand.cols; col++)
                Assert.Equal(rand[row, col], result[row, col]);
    }
}
