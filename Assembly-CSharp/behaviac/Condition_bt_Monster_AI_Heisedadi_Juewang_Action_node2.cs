﻿using System;

namespace behaviac
{
	// Token: 0x02003471 RID: 13425
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Heisedadi_Juewang_Action_node2 : Condition
	{
		// Token: 0x0601512D RID: 86317 RVA: 0x006598E7 File Offset: 0x00657CE7
		public Condition_bt_Monster_AI_Heisedadi_Juewang_Action_node2()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 560001;
		}

		// Token: 0x0601512E RID: 86318 RVA: 0x00659908 File Offset: 0x00657D08
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag != flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400EA30 RID: 59952
		private BE_Target opl_p0;

		// Token: 0x0400EA31 RID: 59953
		private BE_Equal opl_p1;

		// Token: 0x0400EA32 RID: 59954
		private int opl_p2;
	}
}
