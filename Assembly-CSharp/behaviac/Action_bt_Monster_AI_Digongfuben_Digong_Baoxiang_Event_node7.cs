﻿using System;

namespace behaviac
{
	// Token: 0x0200323C RID: 12860
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Digongfuben_Digong_Baoxiang_Event_node7 : Action
	{
		// Token: 0x06014CFA RID: 85242 RVA: 0x006452AB File Offset: 0x006436AB
		public Action_bt_Monster_AI_Digongfuben_Digong_Baoxiang_Event_node7()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = BE_Target.Self;
			this.method_p1 = 570226;
		}

		// Token: 0x06014CFB RID: 85243 RVA: 0x006452CC File Offset: 0x006436CC
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_RemoveBuff(this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E653 RID: 58963
		private BE_Target method_p0;

		// Token: 0x0400E654 RID: 58964
		private int method_p1;
	}
}
