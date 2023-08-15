namespace FastMatrix.Net.Benchmark;

[MemoryDiagnoser(false)]
public class SmallMatmulBenchmark
{
    private const int numMatrices = 128;
    private Matrix[] matrices_64_64 = new Matrix[numMatrices];

    [GlobalSetup]
    public void Setup()
    {
        for (int i = 0; i < matrices_64_64.Length; i++)
            matrices_64_64[i] = Matrix.RandomMatrix(64, 64, 10);

        for (int i = 0; i < numMatrices; i++)
            if (matrices_64_64[i] == null)
                throw new Exception();
    }

    [Benchmark]
    public void Matmul_64_64()
    {
        for (int i = 0; i < matrices_64_64.Length / 2; i++)
            Matrix.Multiply(matrices_64_64[i*2], matrices_64_64[i*2+1]);
    }
}
