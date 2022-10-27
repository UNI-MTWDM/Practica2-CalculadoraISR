using DeLaSalle.TaxCalculator.App.Taxes;
using DeLaSalle.TaxCalculator.Core.Entities;

namespace DeLaSalle.TaxCalculator.Tests;

public class ISRCalculatorServiceShould
{
    [Fact]
    public void Salary_WhenSalaryIsLessTan7735_Return148dot511()
    {
        //arragne,
        var expected = 148.51180799999997;
        var salary = new Salary {Amount = 7735};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIs13500_Return517()
    {
        //arragne,
        var expected = 517.46936;
        var salary = new Salary {Amount = 13500};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIs115375dot9_Return9265()
    {
        //arragne,
        var expected = 9265.200416;
        var salary = new Salary {Amount = 115375.9};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIsLessTan134119dot41_Return12264dot16()
    {
        //arragne,
        var expected = 12264.16;
        var salary = new Salary {Amount = 134119.41};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIs160557dot65_Return17001()
    {
        //arragne,
        var expected = 17001.890816;
        var salary = new Salary {Amount = 160557.65};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIs323862dot_Return51883()
    {
        //arragne,
        var expected = 51883.005024;
        var salary = new Salary {Amount = 323862};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIsLessTan510451_Return95768()
    {
        //arragne,
        var expected = 95768.740448;
        var salary = new Salary {Amount = 510451};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIs974535_Return234993()
    {
        //arragne,
        var expected = 234993.946;
        var salary = new Salary {Amount = 974535.03};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIs1299380_Return338944()
    {
        //arragne,
        var expected = 338944.35000000003;
        var salary = new Salary {Amount = 1299380.04};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIsLessTan3898140_Return1222522()
    {
        //arragne,
        var expected = 1222522.7638000003;
        var salary = new Salary {Amount = 3898140.12};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Salary_WhenSalaryIs3898140dot13_Return1222522dot76()
    {
        //arragne,
        var expected = 1222522.76;
        var salary = new Salary {Amount = 3898140.13};
        var sut = new ISRCalculatorService();
        //act
        var result = sut.GetISR(salary);
        //asset
        Assert.Equal(expected, result);
    }
    
}