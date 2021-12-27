// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the ProcessInfo data model. </summary>
    public partial class ProcessInfoData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of ProcessInfoData. </summary>
        public ProcessInfoData()
        {
            Children = new ChangeTrackingList<string>();
            Threads = new ChangeTrackingList<ProcessThreadInfo>();
            OpenFileHandles = new ChangeTrackingList<string>();
            Modules = new ChangeTrackingList<ProcessModuleInfoData>();
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ProcessInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="identifier"> ARM Identifier for deployment. </param>
        /// <param name="deploymentName"> Deployment name. </param>
        /// <param name="href"> HRef URI. </param>
        /// <param name="minidump"> Minidump URI. </param>
        /// <param name="isProfileRunning"> Is profile running?. </param>
        /// <param name="isIisProfileRunning"> Is the IIS Profile running?. </param>
        /// <param name="iisProfileTimeoutInSeconds"> IIS Profile timeout (seconds). </param>
        /// <param name="parent"> Parent process. </param>
        /// <param name="children"> Child process list. </param>
        /// <param name="threads"> Thread list. </param>
        /// <param name="openFileHandles"> List of open files. </param>
        /// <param name="modules"> List of modules. </param>
        /// <param name="fileName"> File name of this process. </param>
        /// <param name="commandLine"> Command line. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="handleCount"> Handle count. </param>
        /// <param name="moduleCount"> Module count. </param>
        /// <param name="threadCount"> Thread count. </param>
        /// <param name="startTime"> Start time. </param>
        /// <param name="totalCpuTime"> Total CPU time. </param>
        /// <param name="userCpuTime"> User CPU time. </param>
        /// <param name="privilegedCpuTime"> Privileged CPU time. </param>
        /// <param name="workingSet"> Working set. </param>
        /// <param name="peakWorkingSet"> Peak working set. </param>
        /// <param name="privateMemory"> Private memory size. </param>
        /// <param name="virtualMemory"> Virtual memory size. </param>
        /// <param name="peakVirtualMemory"> Peak virtual memory usage. </param>
        /// <param name="pagedSystemMemory"> Paged system memory. </param>
        /// <param name="nonPagedSystemMemory"> Non-paged system memory. </param>
        /// <param name="pagedMemory"> Paged memory. </param>
        /// <param name="peakPagedMemory"> Peak paged memory. </param>
        /// <param name="timeStamp"> Time stamp. </param>
        /// <param name="environmentVariables"> List of environment variables. </param>
        /// <param name="isScmSite"> Is this the SCM site?. </param>
        /// <param name="isWebjob"> Is this a Web Job?. </param>
        /// <param name="description"> Description of process. </param>
        internal ProcessInfoData(ResourceIdentifier id, string name, ResourceType type, string kind, int? identifier, string deploymentName, string href, string minidump, bool? isProfileRunning, bool? isIisProfileRunning, double? iisProfileTimeoutInSeconds, string parent, IList<string> children, IList<ProcessThreadInfo> threads, IList<string> openFileHandles, IList<ProcessModuleInfoData> modules, string fileName, string commandLine, string userName, int? handleCount, int? moduleCount, int? threadCount, DateTimeOffset? startTime, string totalCpuTime, string userCpuTime, string privilegedCpuTime, long? workingSet, long? peakWorkingSet, long? privateMemory, long? virtualMemory, long? peakVirtualMemory, long? pagedSystemMemory, long? nonPagedSystemMemory, long? pagedMemory, long? peakPagedMemory, DateTimeOffset? timeStamp, IDictionary<string, string> environmentVariables, bool? isScmSite, bool? isWebjob, string description) : base(id, name, type, kind)
        {
            Identifier = identifier;
            DeploymentName = deploymentName;
            Href = href;
            Minidump = minidump;
            IsProfileRunning = isProfileRunning;
            IsIisProfileRunning = isIisProfileRunning;
            IisProfileTimeoutInSeconds = iisProfileTimeoutInSeconds;
            Parent = parent;
            Children = children;
            Threads = threads;
            OpenFileHandles = openFileHandles;
            Modules = modules;
            FileName = fileName;
            CommandLine = commandLine;
            UserName = userName;
            HandleCount = handleCount;
            ModuleCount = moduleCount;
            ThreadCount = threadCount;
            StartTime = startTime;
            TotalCpuTime = totalCpuTime;
            UserCpuTime = userCpuTime;
            PrivilegedCpuTime = privilegedCpuTime;
            WorkingSet = workingSet;
            PeakWorkingSet = peakWorkingSet;
            PrivateMemory = privateMemory;
            VirtualMemory = virtualMemory;
            PeakVirtualMemory = peakVirtualMemory;
            PagedSystemMemory = pagedSystemMemory;
            NonPagedSystemMemory = nonPagedSystemMemory;
            PagedMemory = pagedMemory;
            PeakPagedMemory = peakPagedMemory;
            TimeStamp = timeStamp;
            EnvironmentVariables = environmentVariables;
            IsScmSite = isScmSite;
            IsWebjob = isWebjob;
            Description = description;
        }

        /// <summary> ARM Identifier for deployment. </summary>
        public int? Identifier { get; }
        /// <summary> Deployment name. </summary>
        public string DeploymentName { get; set; }
        /// <summary> HRef URI. </summary>
        public string Href { get; set; }
        /// <summary> Minidump URI. </summary>
        public string Minidump { get; set; }
        /// <summary> Is profile running?. </summary>
        public bool? IsProfileRunning { get; set; }
        /// <summary> Is the IIS Profile running?. </summary>
        public bool? IsIisProfileRunning { get; set; }
        /// <summary> IIS Profile timeout (seconds). </summary>
        public double? IisProfileTimeoutInSeconds { get; set; }
        /// <summary> Parent process. </summary>
        public string Parent { get; set; }
        /// <summary> Child process list. </summary>
        public IList<string> Children { get; }
        /// <summary> Thread list. </summary>
        public IList<ProcessThreadInfo> Threads { get; }
        /// <summary> List of open files. </summary>
        public IList<string> OpenFileHandles { get; }
        /// <summary> List of modules. </summary>
        public IList<ProcessModuleInfoData> Modules { get; }
        /// <summary> File name of this process. </summary>
        public string FileName { get; set; }
        /// <summary> Command line. </summary>
        public string CommandLine { get; set; }
        /// <summary> User name. </summary>
        public string UserName { get; set; }
        /// <summary> Handle count. </summary>
        public int? HandleCount { get; set; }
        /// <summary> Module count. </summary>
        public int? ModuleCount { get; set; }
        /// <summary> Thread count. </summary>
        public int? ThreadCount { get; set; }
        /// <summary> Start time. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> Total CPU time. </summary>
        public string TotalCpuTime { get; set; }
        /// <summary> User CPU time. </summary>
        public string UserCpuTime { get; set; }
        /// <summary> Privileged CPU time. </summary>
        public string PrivilegedCpuTime { get; set; }
        /// <summary> Working set. </summary>
        public long? WorkingSet { get; set; }
        /// <summary> Peak working set. </summary>
        public long? PeakWorkingSet { get; set; }
        /// <summary> Private memory size. </summary>
        public long? PrivateMemory { get; set; }
        /// <summary> Virtual memory size. </summary>
        public long? VirtualMemory { get; set; }
        /// <summary> Peak virtual memory usage. </summary>
        public long? PeakVirtualMemory { get; set; }
        /// <summary> Paged system memory. </summary>
        public long? PagedSystemMemory { get; set; }
        /// <summary> Non-paged system memory. </summary>
        public long? NonPagedSystemMemory { get; set; }
        /// <summary> Paged memory. </summary>
        public long? PagedMemory { get; set; }
        /// <summary> Peak paged memory. </summary>
        public long? PeakPagedMemory { get; set; }
        /// <summary> Time stamp. </summary>
        public DateTimeOffset? TimeStamp { get; set; }
        /// <summary> List of environment variables. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; }
        /// <summary> Is this the SCM site?. </summary>
        public bool? IsScmSite { get; set; }
        /// <summary> Is this a Web Job?. </summary>
        public bool? IsWebjob { get; set; }
        /// <summary> Description of process. </summary>
        public string Description { get; set; }
    }
}
