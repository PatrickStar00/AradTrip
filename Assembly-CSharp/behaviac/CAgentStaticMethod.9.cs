﻿using System;

namespace behaviac
{
	// Token: 0x020047AF RID: 18351
	public class CAgentStaticMethod<T, P1, P2, P3, P4, P5, P6, P7, P8> : CAgentMethodBase<T>
	{
		// Token: 0x0601A5E1 RID: 108001 RVA: 0x0082A88B File Offset: 0x00828C8B
		public CAgentStaticMethod(CAgentStaticMethod<T, P1, P2, P3, P4, P5, P6, P7, P8>.FunctionPointer f)
		{
			this._fp = f;
		}

		// Token: 0x0601A5E2 RID: 108002 RVA: 0x0082A89C File Offset: 0x00828C9C
		public CAgentStaticMethod(CAgentStaticMethod<T, P1, P2, P3, P4, P5, P6, P7, P8> rhs) : base(rhs)
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
		}

		// Token: 0x0601A5E3 RID: 108003 RVA: 0x0082A91C File Offset: 0x00828D1C
		public override IMethod Clone()
		{
			return new CAgentStaticMethod<T, P1, P2, P3, P4, P5, P6, P7, P8>(this);
		}

		// Token: 0x0601A5E4 RID: 108004 RVA: 0x0082A924 File Offset: 0x00828D24
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
		}

		// Token: 0x0601A5E5 RID: 108005 RVA: 0x0082A9A8 File Offset: 0x00828DA8
		public override void Run(Agent self)
		{
			this._returnValue.value = this._fp(((CInstanceMember<P1>)this._p1).GetValue(self), ((CInstanceMember<P2>)this._p2).GetValue(self), ((CInstanceMember<P3>)this._p3).GetValue(self), ((CInstanceMember<P4>)this._p4).GetValue(self), ((CInstanceMember<P5>)this._p5).GetValue(self), ((CInstanceMember<P6>)this._p6).GetValue(self), ((CInstanceMember<P7>)this._p7).GetValue(self), ((CInstanceMember<P8>)this._p8).GetValue(self));
		}

		// Token: 0x0601A5E6 RID: 108006 RVA: 0x0082AA54 File Offset: 0x00828E54
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
		}

		// Token: 0x040127BF RID: 75711
		private CAgentStaticMethod<T, P1, P2, P3, P4, P5, P6, P7, P8>.FunctionPointer _fp;

		// Token: 0x040127C0 RID: 75712
		private IInstanceMember _p1;

		// Token: 0x040127C1 RID: 75713
		private IInstanceMember _p2;

		// Token: 0x040127C2 RID: 75714
		private IInstanceMember _p3;

		// Token: 0x040127C3 RID: 75715
		private IInstanceMember _p4;

		// Token: 0x040127C4 RID: 75716
		private IInstanceMember _p5;

		// Token: 0x040127C5 RID: 75717
		private IInstanceMember _p6;

		// Token: 0x040127C6 RID: 75718
		private IInstanceMember _p7;

		// Token: 0x040127C7 RID: 75719
		private IInstanceMember _p8;

		// Token: 0x020047B0 RID: 18352
		// (Invoke) Token: 0x0601A5E8 RID: 108008
		public delegate T FunctionPointer(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6, P7 p7, P8 p8);
	}
}
