﻿// ***********************************************************************
// Copyright (c) 2016 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using Microsoft.Extensions.Testing.Abstractions;
using MsTest = Microsoft.Extensions.Testing.Abstractions.Test;
using MsTestResult = Microsoft.Extensions.Testing.Abstractions.TestResult;

namespace NUnit.Runner.Test.Mocks
{
    public class MockTestExecutionSink : ITestExecutionSink
    {
        public bool WaitingCommandReceived { get; private set; }

        public MsTest TestStarted { get; private set; }

        public bool TestCompletedReceived { get; private set; }

        public MsTestResult TestResult { get; private set; }

        public void SendWaitingCommand()
        {
            WaitingCommandReceived = true;
        }

        public void SendTestStarted(MsTest test)
        {
            TestStarted = test;
        }

        public void SendTestCompleted()
        {
            TestCompletedReceived = true;
        }

        public void SendTestResult(MsTestResult testResult)
        {
            TestResult = testResult;
        }
    }
}
