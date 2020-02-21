// Copyright 2014-2020 Kasper B. Graversen
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

using System;
using StatePrinting.FieldHarvesters;
using StatePrinting.OutputFormatters;
using StatePrinting.TestAssistance;
using StatePrinting.ValueConverters;

namespace StatePrinting.Configurations
{
    /// <summary>
    /// Helper for configuration
    /// </summary>
    public static class ConfigurationHelper
    {
        /// <summary>
        /// Return a configuration which covers most usages.
        /// The configuration returned can be further remolded by adding additional handlers. 
        /// 
        /// Eg. add a <see cref="PublicFieldsHarvester"/> to restrict the printed state to only public fields.
        /// </summary>
        public static Configuration GetStandardConfiguration(TestFrameworkAreEqualsMethod areEqualsMethod)
        {
            if (areEqualsMethod == null) 
                throw new ArgumentNullException("areEqualsMethod");

            return GetStandardConfiguration(
                Configuration.DefaultIndention,
                areEqualsMethod: areEqualsMethod);
        }

        /// <summary>
        /// Return a configuration which covers most usages.
        /// The configuration returned can be further remolded by adding additional handlers. 
        /// 
        /// Eg. add a <see cref="PublicFieldsHarvester"/> to restrict the printed state to only public fields.
        /// </summary>
        public static Configuration GetStandardConfiguration(
            string indentIncrement = Configuration.DefaultIndention,
            TestFrameworkAreEqualsMethod areEqualsMethod = null)
        {
            var cfg = new Configuration(indentIncrement, areEqualsMethod);

            // valueconverters
            cfg.Add(new StandardTypesConverter(cfg));
            cfg.Add(new StringConverter());
            cfg.Add(new DateTimeConverter(cfg));
            cfg.Add(new EnumConverter());

            // harvesters
            cfg.Add(new AllFieldsHarvester());

            // outputformatters
            cfg.OutputFormatter = new CurlyBraceStyle(cfg);

            return cfg;
        }
    }
}