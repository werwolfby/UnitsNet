﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ThermalResistance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ThermalResistanceTestsBase
    {
        protected abstract double HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt { get; }
        protected abstract double SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double HourSquareFeetDegreesFahrenheitPerBtuTolerance { get { return 1e-5; } }
        protected virtual double SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance { get { return 1e-5; } }
        protected virtual double SquareCentimeterKelvinsPerWattTolerance { get { return 1e-5; } }
        protected virtual double SquareMeterDegreesCelsiusPerWattTolerance { get { return 1e-5; } }
        protected virtual double SquareMeterKelvinsPerKilowattTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void SquareMeterKelvinPerKilowattToThermalResistanceUnits()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.HourSquareFeetDegreesFahrenheitPerBtu, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareCentimeterHourDegreesCelsiusPerKilocalorie, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareCentimeterKelvinsPerWatt, SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareMeterDegreesCelsiusPerWatt, SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu).HourSquareFeetDegreesFahrenheitPerBtu, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie).SquareCentimeterHourDegreesCelsiusPerKilocalorie, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.SquareCentimeterKelvinPerWatt).SquareCentimeterKelvinsPerWatt, SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt).SquareMeterDegreesCelsiusPerWatt, SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.From(1, ThermalResistanceUnit.SquareMeterKelvinPerKilowatt).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void As()
        {
            var squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(HourSquareFeetDegreesFahrenheitPerBtuInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu), HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(SquareCentimeterHourDegreesCelsiusPerKilocalorieInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie), SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(SquareCentimeterKelvinsPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt), SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterDegreesCelsiusPerWattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt), SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(SquareMeterKelvinsPerKilowattInOneSquareMeterKelvinPerKilowatt, squaremeterkelvinperkilowatt.As(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt), SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(1, ThermalResistance.FromHourSquareFeetDegreesFahrenheitPerBtu(squaremeterkelvinperkilowatt.HourSquareFeetDegreesFahrenheitPerBtu).SquareMeterKelvinsPerKilowatt, HourSquareFeetDegreesFahrenheitPerBtuTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareCentimeterHourDegreesCelsiusPerKilocalorie(squaremeterkelvinperkilowatt.SquareCentimeterHourDegreesCelsiusPerKilocalorie).SquareMeterKelvinsPerKilowatt, SquareCentimeterHourDegreesCelsiusPerKilocalorieTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareCentimeterKelvinsPerWatt(squaremeterkelvinperkilowatt.SquareCentimeterKelvinsPerWatt).SquareMeterKelvinsPerKilowatt, SquareCentimeterKelvinsPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareMeterDegreesCelsiusPerWatt(squaremeterkelvinperkilowatt.SquareMeterDegreesCelsiusPerWatt).SquareMeterKelvinsPerKilowatt, SquareMeterDegreesCelsiusPerWattTolerance);
            AssertEx.EqualTolerance(1, ThermalResistance.FromSquareMeterKelvinsPerKilowatt(squaremeterkelvinperkilowatt.SquareMeterKelvinsPerKilowatt).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ThermalResistance v = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            AssertEx.EqualTolerance(-1, -v.SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (ThermalResistance.FromSquareMeterKelvinsPerKilowatt(3)-v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (v + v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(10, (v*10).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(10, (10*v).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, (ThermalResistance.FromSquareMeterKelvinsPerKilowatt(10)/5).SquareMeterKelvinsPerKilowatt, SquareMeterKelvinsPerKilowattTolerance);
            AssertEx.EqualTolerance(2, ThermalResistance.FromSquareMeterKelvinsPerKilowatt(10)/ThermalResistance.FromSquareMeterKelvinsPerKilowatt(5), SquareMeterKelvinsPerKilowattTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ThermalResistance oneSquareMeterKelvinPerKilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            ThermalResistance twoSquareMeterKelvinsPerKilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(2);

            Assert.True(oneSquareMeterKelvinPerKilowatt < twoSquareMeterKelvinsPerKilowatt);
            Assert.True(oneSquareMeterKelvinPerKilowatt <= twoSquareMeterKelvinsPerKilowatt);
            Assert.True(twoSquareMeterKelvinsPerKilowatt > oneSquareMeterKelvinPerKilowatt);
            Assert.True(twoSquareMeterKelvinsPerKilowatt >= oneSquareMeterKelvinPerKilowatt);

            Assert.False(oneSquareMeterKelvinPerKilowatt > twoSquareMeterKelvinsPerKilowatt);
            Assert.False(oneSquareMeterKelvinPerKilowatt >= twoSquareMeterKelvinsPerKilowatt);
            Assert.False(twoSquareMeterKelvinsPerKilowatt < oneSquareMeterKelvinPerKilowatt);
            Assert.False(twoSquareMeterKelvinsPerKilowatt <= oneSquareMeterKelvinPerKilowatt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Equal(0, squaremeterkelvinperkilowatt.CompareTo(squaremeterkelvinperkilowatt));
            Assert.True(squaremeterkelvinperkilowatt.CompareTo(ThermalResistance.Zero) > 0);
            Assert.True(ThermalResistance.Zero.CompareTo(squaremeterkelvinperkilowatt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Throws<ArgumentException>(() => squaremeterkelvinperkilowatt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.Throws<ArgumentNullException>(() => squaremeterkelvinperkilowatt.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ThermalResistance a = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            ThermalResistance b = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ThermalResistance v = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.True(v.Equals(ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1)));
            Assert.False(v.Equals(ThermalResistance.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.False(squaremeterkelvinperkilowatt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ThermalResistance squaremeterkelvinperkilowatt = ThermalResistance.FromSquareMeterKelvinsPerKilowatt(1);
            Assert.False(squaremeterkelvinperkilowatt.Equals(null));
        }
    }
}
