﻿using System;

namespace behaviac
{
	// Token: 0x02003506 RID: 13574
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Heisedadi_Nadeer_Event_1_node46 : Action
	{
		// Token: 0x0601524F RID: 86607 RVA: 0x0065EEBF File Offset: 0x0065D2BF
		public Action_bt_Monster_AI_Heisedadi_Nadeer_Event_1_node46()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = BE_Target.Self;
			this.method_p1 = 521746;
		}

		// Token: 0x06015250 RID: 86608 RVA: 0x0065EEE0 File Offset: 0x0065D2E0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_RemoveBuff(this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EB89 RID: 60297
		private BE_Target method_p0;

		// Token: 0x0400EB8A RID: 60298
		private int method_p1;
	}
}
