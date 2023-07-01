0
1
1
4
5
6
7
6
5
13
11
21
X 
  13
14
15
00
7
45
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
X
42
43
44
45
46
47
48
49
50
51
52
53
54
55
56
57
58
59
60
61
62
63
64
65
66
67
68
69
70
71
72
73
74
75
76
77
78
79
80
81
82
83
84
85
86
87
88
89
90
91
92
93
94
95
96
97
98
99
100
//----------------------------------------------------
// <copyright file="PerformanceCounterPermissionEntryCollection.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------
 
namespace System.Diagnostics {
    using System.Security.Permissions;
    using System.Collections;
    
    [
    Serializable()
    ]
    public class PerformanceCounterPermissionEntryCollection : CollectionBase {        
        PerformanceCounterPermission owner;
        
        ///<internalonly/>   
        internal PerformanceCounterPermissionEntryCollection(PerformanceCounterPermission owner, ResourcePermissionBaseEntry[] entries) {
            this.owner = owner;
            for (int index = 0; index < entries.Length; ++index)
                this.InnerList.Add(new PerformanceCounterPermissionEntry(entries[index]));
        }                                                                                                              
                                                                                                            
        public PerformanceCounterPermissionEntry this[int index] {
            get {
                return (PerformanceCounterPermissionEntry)List[index];
            }
            set {
                List[index] = value;
            }
            
        }
        
        public int Add(PerformanceCounterPermissionEntry value) {   
            return List.Add(value);
        }
        
        public void AddRange(PerformanceCounterPermissionEntry[] value) {            
            if (value == null) {
                throw new ArgumentNullException("value");
            }
            for (int i = 0; ((i) < (value.Length)); i = ((i) + (1))) {
                this.Add(value[i]);
            }
        }
    
        public void AddRange(PerformanceCounterPermissionEntryCollection value) {            
            if (value == null) {
                throw new ArgumentNullException("value");
            }
            int currentCount = value.Count;
            for (int i = 0; i < currentCount; i = ((i) + (1))) {
                this.Add(value[i]);
            }
        }         
    
        public bool Contains(PerformanceCounterPermissionEntry value) {            
            return List.Contains(value);
        }
    
        public void CopyTo(PerformanceCounterPermissionEntry[] array, int index) {            
            List.CopyTo(array, index);
        }
    
        public int IndexOf(PerformanceCounterPermissionEntry value) {            
            return List.IndexOf(value);
        }
        
        public void Insert(int index, PerformanceCounterPermissionEntry value) {            
            List.Insert(index, value);
        }
                
        public void Remove(PerformanceCounterPermissionEntry value) {
            List.Remove(value);                     
        }
        
        ///<internalonly/>                          
        protected override void OnClear() {   
            this.owner.Clear();         
        }
        
        ///<internalonly/>                          
        protected override void OnInsert(int index, object value) {        
            this.owner.AddPermissionAccess((PerformanceCounterPermissionEntry)value);
        }
        
        ///<internalonly/>                          
        protected override void OnRemove(int index, object value) {
            this.owner.RemovePermissionAccess((PerformanceCounterPermissionEntry)value);
        }
                 
        ///<internalonly/>                          
        protected override void OnSet(int index, object oldValue, object newValue) {     
            this.owner.RemovePermissionAccess((PerformanceCounterPermissionEntry)oldValue);
            this.owner.AddPermissionAccess((PerformanceCounterPermissionEntry)newValue);       
        } 
    }1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
23
24
25
26
27
28
29
30
31
32
33
34
35
36
37
38
39
40
41
42
43
44
45
46
47
48
49
50
51
52
53
54
55
56
57
58
59
60
61
62
63
64
65
66
67
68
69
70
71
72
73
74
75
76
77
78
79
80
81
82
83
84
85
86
87
88
89
90
91
92
93
94
95
96
97
98
99
100
//----------------------------------------------------
// <copyright file="PerformanceCounterPermissionEntryCollection.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------
 
namespace System.Diagnostics {
    using System.Security.Permissions;
    using System.Collections;
    
    [
    Serializable()
    ]
    public class PerformanceCounterPermissionEntryCollection : CollectionBase {        
        PerformanceCounterPermission owner;
        
        ///<internalonly/>   
        internal PerformanceCounterPermissionEntryCollection(PerformanceCounterPermission owner, ResourcePermissionBaseEntry[] entries) {
            this.owner = owner;
            for (int index = 0; index < entries.Length; ++index)
                this.InnerList.Add(new PerformanceCounterPermissionEntry(entries[index]));
        }                                                                                                              
                                                                                                            
        public PerformanceCounterPermissionEntry this[int index] {
            get {
                return (PerformanceCounterPermissionEntry)List[index];
            }
            set {
                List[index] = value;
            }
            
        }
        
        public int Add(PerformanceCounterPermissionEntry value) {   
            return List.Add(value);
        }
        
        public void AddRange(PerformanceCounterPermissionEntry[] value) {            
            if (value == null) {
                throw new ArgumentNullException("value");
            }
            for (int i = 0; ((i) < (value.Length)); i = ((i) + (1))) {
                this.Add(value[i]);
            }
        }
    
        public void AddRange(PerformanceCounterPermissionEntryCollection value) {            
            if (value == null) {
                throw new ArgumentNullException("value");
            }
            int currentCount = value.Count;
            for (int i = 0; i < currentCount; i = ((i) + (1))) {
                this.Add(value[i]);
            }
        }         
    
        public bool Contains(PerformanceCounterPermissionEntry value) {            
            return List.Contains(value);
        }
    
        public void CopyTo(PerformanceCounterPermissionEntry[] array, int index) {            
            List.CopyTo(array, index);
        }
    
        public int IndexOf(PerformanceCounterPermissionEntry value) {            
            return List.IndexOf(value);
        }
        
        public void Insert(int index, PerformanceCounterPermissionEntry value) {            
            List.Insert(index, value);
        }
                
        public void Remove(PerformanceCounterPermissionEntry value) {
            List.Remove(value);                     
        }
        
        ///<internalonly/>                          
        protected override void OnClear() {   
            this.owner.Clear();         
        }
        
        ///<internalonly/>                          
        protected override void OnInsert(int index, object value) {        
            this.owner.AddPermissionAccess((PerformanceCounterPermissionEntry)value);
        }
        
        ///<internalonly/>                          
        protected override void OnRemove(int index, object value) {
            this.owner.RemovePermissionAccess((PerformanceCounterPermissionEntry)value);
        }
                 
        ///<internalonly/>                          
        protected override void OnSet(int index, object oldValue, object newValue) {     
            this.owner.RemovePermissionAccess((PerformanceCounterPermissionEntry)oldValue);
            this.owner.AddPermissionAccess((PerformanceCounterPermissionEntry)newValue);       
        } 
    }
