﻿using System;

namespace behaviac
{
	// Token: 0x0200245F RID: 9311
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Fight_Swordman_veryhard_Action_node21 : Condition
	{
		// Token: 0x0601320F RID: 78351 RVA: 0x005AD16B File Offset: 0x005AB56B
		public Condition_bt_AutoFight_AutoFight_Fight_Swordman_veryhard_Action_node21()
		{
			this.opl_p0 = 1505;
		}

		// Token: 0x06013210 RID: 78352 RVA: 0x005AD180 File Offset: 0x005AB580
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CC34 RID: 52276
		private int opl_p0;
	}
}
