// FailingMockTestThing.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;

namespace Cirrious.MvvmCross.Test.Mocks.TestViewModels
{
    public class FailingMockTestThing : ITestThing
    {
        public FailingMockTestThing()
        {
            throw new Exception("I always fail");
        }
    }
}