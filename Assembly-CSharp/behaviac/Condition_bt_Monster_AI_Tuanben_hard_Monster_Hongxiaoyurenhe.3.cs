﻿using System;

namespace behaviac
{
	// Token: 0x02003D17 RID: 15639
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_hard_Monster_Hongxiaoyurenheti_action_hard_node11 : Condition
	{
		// Token: 0x060161CA RID: 90570 RVA: 0x006AF3ED File Offset: 0x006AD7ED
		public Condition_bt_Monster_AI_Tuanben_hard_Monster_Hongxiaoyurenheti_action_hard_node11()
		{
			this.opl_p0 = 21301;
		}

		// Token: 0x060161CB RID: 90571 RVA: 0x006AF400 File Offset: 0x006AD800
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_HaveSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FA50 RID: 64080
		private int opl_p0;
	}
}
