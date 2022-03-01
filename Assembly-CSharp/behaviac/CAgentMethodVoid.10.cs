﻿using System;

namespace behaviac
{
	// Token: 0x020047D0 RID: 18384
	public class CAgentMethodVoid<P1, P2, P3, P4, P5, P6, P7, P8, P9> : CAgentMethodVoidBase
	{
		// Token: 0x0601A692 RID: 108178 RVA: 0x0082D791 File Offset: 0x0082BB91
		public CAgentMethodVoid(CAgentMethodVoid<P1, P2, P3, P4, P5, P6, P7, P8, P9>.FunctionPointer f)
		{
			this._fp = f;
		}

		// Token: 0x0601A693 RID: 108179 RVA: 0x0082D7A0 File Offset: 0x0082BBA0
		public CAgentMethodVoid(CAgentMethodVoid<P1, P2, P3, P4, P5, P6, P7, P8, P9> rhs) : base(rhs)
		{
			this._fp = rhs._fp;
			this._p1 = rhs._p1;
			this._p2 = rhs._p2;
			this._p3 = rhs._p3;
			this._p4 = rhs._p4;
			this._p5 = rhs._p5;
			this._p6 = rhs._p6;
			this._p7 = rhs._p7;
			this._p8 = rhs._p8;
			this._p9 = rhs._p9;
		}

		// Token: 0x0601A694 RID: 108180 RVA: 0x0082D82C File Offset: 0x0082BC2C
		public override IMethod Clone()
		{
			return new CAgentMethodVoid<P1, P2, P3, P4, P5, P6, P7, P8, P9>(this);
		}

		// Token: 0x0601A695 RID: 108181 RVA: 0x0082D834 File Offset: 0x0082BC34
		public override void Load(string instance, string[] paramStrs)
		{
			this._instance = instance;
			this._p1 = AgentMeta.ParseProperty<P1>(paramStrs[0]);
			this._p2 = AgentMeta.ParseProperty<P2>(paramStrs[1]);
			this._p3 = AgentMeta.ParseProperty<P3>(paramStrs[2]);
			this._p4 = AgentMeta.ParseProperty<P4>(paramStrs[3]);
			this._p5 = AgentMeta.ParseProperty<P5>(paramStrs[4]);
			this._p6 = AgentMeta.ParseProperty<P6>(paramStrs[5]);
			this._p7 = AgentMeta.ParseProperty<P7>(paramStrs[6]);
			this._p8 = AgentMeta.ParseProperty<P8>(paramStrs[7]);
			this._p9 = AgentMeta.ParseProperty<P9>(paramStrs[8]);
		}

		// Token: 0x0601A696 RID: 108182 RVA: 0x0082D8C8 File Offset: 0x0082BCC8
		public override void Run(Agent self)
		{
			Agent parentAgent = Utils.GetParentAgent(self, this._instance);
			this._fp(parentAgent, ((CInstanceMember<P1>)this._p1).GetValue(self), ((CInstanceMember<P2>)this._p2).GetValue(self), ((CInstanceMember<P3>)this._p3).GetValue(self), ((CInstanceMember<P4>)this._p4).GetValue(self), ((CInstanceMember<P5>)this._p5).GetValue(self), ((CInstanceMember<P6>)this._p6).GetValue(self), ((CInstanceMember<P7>)this._p7).GetValue(self), ((CInstanceMember<P8>)this._p8).GetValue(self), ((CInstanceMember<P9>)this._p9).GetValue(self));
		}

		// Token: 0x0601A697 RID: 108183 RVA: 0x0082D988 File Offset: 0x0082BD88
		public override void SetTaskParams(Agent self, BehaviorTreeTask treeTask)
		{
			string variableName = string.Format("{0}{1}", "_$local_task_param_$_", 0);
			treeTask.SetVariable<P1>(variableName, ((CInstanceMember<P1>)this._p1).GetValue(self));
			variableName = string.Format("{0}{1}", "_$local_task_param_$_", 1);
			treeTask.SetVariable<P2>(variableName, ((CInstanceMember<P2>)this._p2).GetValue(self));
			variableName = string.Format("{0}{1}", "_$local_task_param_$_", 2);
			treeTask.SetVariable<P3>(variableName, ((CInstanceMember<P3>)this._p3).GetValue(self));
			variableName = string.Format("{0}{1}", "_$local_task_param_$_", 3);
			treeTask.SetVariable<P4>(variableName, ((CInstanceMember<P4>)this._p4).GetValue(self));
			variableName = string.Format("{0}{1}", "_$local_task_param_$_", 4);
			treeTask.SetVariable<P5>(variableName, ((CInstanceMember<P5>)this._p5).GetValue(self));
			variableName = string.Format("{0}{1}", "_$local_task_param_$_", 5);
			treeTask.SetVariable<P6>(variableName, ((CInstanceMember<P6>)this._p6).GetValue(self));
			variableName = string.Format("{0}{1}", "_$local_task_param_$_", 6);
			treeTask.SetVariable<P7>(variableName, ((CInstanceMember<P7>)this._p7).GetValue(self));
			variableName = string.Format("{0}{1}", "_$local_task_param_$_", 7);
			treeTask.SetVariable<P8>(variableName, ((CInstanceMember<P8>)this._p8).GetValue(self));
			variableName = string.Format("{0}{1}", "_$local_task_param_$_", 8);
			treeTask.SetVariable<P9>(variableName, ((CInstanceMember<P9>)this._p9).GetValue(self));
		}

		// Token: 0x04012841 RID: 75841
		private CAgentMethodVoid<P1, P2, P3, P4, P5, P6, P7, P8, P9>.FunctionPointer _fp;

		// Token: 0x04012842 RID: 75842
		private IInstanceMember _p1;

		// Token: 0x04012843 RID: 75843
		private IInstanceMember _p2;

		// Token: 0x04012844 RID: 75844
		private IInstanceMember _p3;

		// Token: 0x04012845 RID: 75845
		private IInstanceMember _p4;

		// Token: 0x04012846 RID: 75846
		private IInstanceMember _p5;

		// Token: 0x04012847 RID: 75847
		private IInstanceMember _p6;

		// Token: 0x04012848 RID: 75848
		private IInstanceMember _p7;

		// Token: 0x04012849 RID: 75849
		private IInstanceMember _p8;

		// Token: 0x0401284A RID: 75850
		private IInstanceMember _p9;

		// Token: 0x020047D1 RID: 18385
		// (Invoke) Token: 0x0601A699 RID: 108185
		public delegate void FunctionPointer(Agent a, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8, P9 p9);
	}
}
