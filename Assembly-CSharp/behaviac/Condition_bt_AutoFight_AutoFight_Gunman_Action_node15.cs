﻿using System;

namespace behaviac
{
	// Token: 0x02002570 RID: 9584
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Gunman_Action_node15 : Condition
	{
		// Token: 0x06013428 RID: 78888 RVA: 0x005B9CC1 File Offset: 0x005B80C1
		public Condition_bt_AutoFight_AutoFight_Gunman_Action_node15()
		{
			this.opl_p0 = 1014;
		}

		// Token: 0x06013429 RID: 78889 RVA: 0x005B9CD4 File Offset: 0x005B80D4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CE51 RID: 52817
		private int opl_p0;
	}
}
