﻿// Copyright 2007-2010 The Apache Software Foundation.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace klinger.Config
{
    using System;

    public interface KlingerConfiguration
    {
        void RegisterValidator<TValidator>() where TValidator : EnvironmentValidator, new();
        void HostWebServerInProcess(int port);
        void ScheduleValidations(TimeSpan interval);
        void ScheduleValidations(TimeSpan delayInterval, TimeSpan interval);
        void OnWarning(Action<VoteBundle> action);
        void OnFatal(Action<VoteBundle> action);
        void RegisterAllValidatorsInAssembly<T>();
    }
}