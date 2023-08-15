namespace FastMatrix.Net.Test;

public class MatmulTest
{
    [Fact]
    public void NaiveMatmulTest()
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

    [Fact]
    public void StrassenMatmulTest()
    {
        var id = Matrix.IdentityMatrix(64, 64);
        var rand = Matrix.RandomMatrix(64, 64, 10);
        var result = Matrix.Multiply(rand, id);

        Assert.Equal(rand.rows, result.rows);
        Assert.Equal(rand.cols, result.cols);

        for (int row = 0; row < rand.rows; row++)
            for (int col = 0; col < rand.cols; col++)
                Assert.Equal(rand[row, col], result[row, col]);
    }
}
