﻿using System;

namespace behaviac
{
	// Token: 0x02002D5A RID: 11610
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_65Tuanben_Chuanyuezhehuoyaotong_Event_node11 : Condition
	{
		// Token: 0x06014397 RID: 82839 RVA: 0x006134B6 File Offset: 0x006118B6
		public Condition_bt_Monster_AI_65Tuanben_Chuanyuezhehuoyaotong_Event_node11()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 522217;
		}

		// Token: 0x06014398 RID: 82840 RVA: 0x006134D8 File Offset: 0x006118D8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400DD62 RID: 56674
		private BE_Target opl_p0;

		// Token: 0x0400DD63 RID: 56675
		private BE_Equal opl_p1;

		// Token: 0x0400DD64 RID: 56676
		private int opl_p2;
	}
}
