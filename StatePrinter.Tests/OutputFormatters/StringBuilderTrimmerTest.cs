﻿// Copyright 2014-2020 Kasper B. Graversen
// 
// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System.Text;
using NUnit.Framework;
using StatePrinting.OutputFormatters;

namespace StatePrinting.Tests.OutputFormatters
{
    [TestFixture]
    class StringBuilderTrimmerTest
    {
        [Test]
        public void TestTrimLast_Empty()
        {
            var sb = new StringBuilder("");
            Assert.AreEqual(0, new StringBuilderTrimmer(true).TrimLast(sb));
        }

        [Test]
        public void TestTrimLast_NothingToTrim()
        {
            var sb = new StringBuilder("abvc");
            Assert.AreEqual(0, new StringBuilderTrimmer(true).TrimLast(sb));
        }

        [Test]
        public void TestTrimLast_TrimSpaces()
        {
            var sb = new StringBuilder("abvc  ");
            Assert.AreEqual(2, new StringBuilderTrimmer(true).TrimLast(sb));
        }

        [Test]
        public void TestTrimLast_TrimAllSpaces()
        {
            var sb = new StringBuilder("   ");
            Assert.AreEqual(3, new StringBuilderTrimmer(true).TrimLast(sb));
            Assert.AreEqual(3, new StringBuilderTrimmer(false).TrimLast(sb));
        }
        [Test]
        public void TestTrimLast_TrimAllNewlines()
        {
            var sb = new StringBuilder("   \r\n");
            Assert.AreEqual(2, new StringBuilderTrimmer(true).TrimLast(sb));
            Assert.AreEqual(0, new StringBuilderTrimmer(false).TrimLast(sb));
        }
    }
}
