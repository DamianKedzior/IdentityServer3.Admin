﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
 
namespace IdentityAdmin.Configuration
{
    /// <summary>
    /// Allows resolving dependencies from the dependency injection system.
    /// </summary>
    public interface IDependencyResolver
    {
        /// <summary>
        /// Resolves the dependency based upon the type. If name is provided then the dependency is also resolved by name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns>The dependency.</returns>
        T Resolve<T>(string name = null);
    }
}