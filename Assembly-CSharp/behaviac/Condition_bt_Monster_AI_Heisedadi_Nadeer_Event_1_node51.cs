﻿using System;

namespace behaviac
{
	// Token: 0x0200350E RID: 13582
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Heisedadi_Nadeer_Event_1_node51 : Condition
	{
		// Token: 0x0601525F RID: 86623 RVA: 0x0065F0CC File Offset: 0x0065D4CC
		public Condition_bt_Monster_AI_Heisedadi_Nadeer_Event_1_node51()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 521774;
		}

		// Token: 0x06015260 RID: 86624 RVA: 0x0065F0F0 File Offset: 0x0065D4F0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EB9C RID: 60316
		private BE_Target opl_p0;

		// Token: 0x0400EB9D RID: 60317
		private BE_Equal opl_p1;

		// Token: 0x0400EB9E RID: 60318
		private int opl_p2;
	}
}
