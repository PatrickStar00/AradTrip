﻿using System;

namespace behaviac
{
	// Token: 0x02003B6B RID: 15211
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Shuiren_Boss_ACTION_node46 : Condition
	{
		// Token: 0x06015E8B RID: 89739 RVA: 0x0069E0AB File Offset: 0x0069C4AB
		public Condition_bt_Monster_AI_Tuanben_Shuiren_Boss_ACTION_node46()
		{
			this.opl_p0 = 5000;
			this.opl_p1 = 2000;
			this.opl_p2 = 1500;
			this.opl_p3 = 1500;
		}

		// Token: 0x06015E8C RID: 89740 RVA: 0x0069E0E0 File Offset: 0x0069C4E0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_IsTargetInAttackArea(this.opl_p0, this.opl_p1, this.opl_p2, this.opl_p3);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F750 RID: 63312
		private int opl_p0;

		// Token: 0x0400F751 RID: 63313
		private int opl_p1;

		// Token: 0x0400F752 RID: 63314
		private int opl_p2;

		// Token: 0x0400F753 RID: 63315
		private int opl_p3;
	}
}
