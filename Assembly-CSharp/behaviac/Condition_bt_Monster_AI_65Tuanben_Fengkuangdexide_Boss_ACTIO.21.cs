﻿using System;

namespace behaviac
{
	// Token: 0x02002ECB RID: 11979
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_65Tuanben_Fengkuangdexide_Boss_ACTION_node11 : Condition
	{
		// Token: 0x06014670 RID: 83568 RVA: 0x0062270F File Offset: 0x00620B0F
		public Condition_bt_Monster_AI_65Tuanben_Fengkuangdexide_Boss_ACTION_node11()
		{
			this.opl_p0 = 21592;
		}

		// Token: 0x06014671 RID: 83569 RVA: 0x00622724 File Offset: 0x00620B24
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400DFDB RID: 57307
		private int opl_p0;
	}
}
