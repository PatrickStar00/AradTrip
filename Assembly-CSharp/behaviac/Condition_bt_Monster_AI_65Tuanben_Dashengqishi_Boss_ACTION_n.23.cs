﻿using System;

namespace behaviac
{
	// Token: 0x02002DAA RID: 11690
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Boss_ACTION_node3 : Condition
	{
		// Token: 0x06014435 RID: 82997 RVA: 0x006161E1 File Offset: 0x006145E1
		public Condition_bt_Monster_AI_65Tuanben_Dashengqishi_Boss_ACTION_node3()
		{
			this.opl_p0 = 21643;
		}

		// Token: 0x06014436 RID: 82998 RVA: 0x006161F4 File Offset: 0x006145F4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400DDFB RID: 56827
		private int opl_p0;
	}
}
