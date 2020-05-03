using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTestCs
{


    /**
 * Oil_2.java
 * ©2006-2016 四海兴唐科技有限公司 
 * All rights reserved.
 * <link>胖先生作品</link>
 * 创建于: 2020-03-13 14:59:50
 **/


    /**
     * oil_2 类

     * 文件创建于: 2020-03-13 14:59:50
     **/
    class Oil
    {


        public String toString()
        {
            return "Oil_2 [dateTime=" + dateTime + ", time=" + time + ", wellDep=" + wellDep + ", hangDownDeep="
                    + hangDownDeep + ", depthOfTheDrillBit=" + depthOfTheDrillBit + ", drillDownDeep=" + drillDownDeep
                    + ", drillingTime=" + drillingTime + ", bitPressure=" + bitPressure + ", hangingLoad=" + hangingLoad
                    + ", rotationRate=" + rotationRate + ", torque=" + torque + ", kellyDown=" + kellyDown
                    + ", hookPosition=" + hookPosition + ", hookSpeed=" + hookSpeed + ", standpipePressurelog="
                    + standpipePressurelog + ", casingPressure=" + casingPressure + ", pumpStroke1=" + pumpStroke1
                    + ", pumpStroke2=" + pumpStroke2 + ", pumpStroke3=" + pumpStroke3 + ", totalPoolSize=" + totalPoolSize
                    + ", layTime=" + layTime + ", mudSpill=" + mudSpill + ", inletFlowlog=" + inletFlowlog
                    + ", outletFlowlog=" + outletFlowlog + ", inletDensitylog=" + inletDensitylog + ", outletDensitylog="
                    + outletDensitylog + ", entranceTempreture=" + entranceTempreture + ", exitTempreture=" + exitTempreture
                    + ", totalHydrocarbon=" + totalHydrocarbon + ", h2S=" + h2S + ", c1=" + c1 + ", c2=" + c2
                    + ", PWDDepth=" + PWDDepth + ", PWDHangDownDeep=" + PWDHangDownDeep + ", PWD_zzyl=" + PWD_zzyl
                    + ", PWD_hkyl=" + PWD_hkyl + ", PWD_hkwd=" + PWD_hkwd + ", PWD_cl_ECD=" + PWD_cl_ECD
                    + ", PWDWellDeviation=" + PWDWellDeviation + ", PWDLocation=" + PWDLocation + ", qztj=" + qztj
                    + ", upturnDepth=" + upturnDepth + ", operatorSchema=" + operatorSchema + ", standpipePressure="
                    + standpipePressure + ", measurementOfBackPressure=" + measurementOfBackPressure + ", outletFlow="
                    + outletFlow + ", outletDensity=" + outletDensity + ", backPressurePumpFlow=" + backPressurePumpFlow
                    + ", loopBackPressure=" + loopBackPressure + ", additionalBackPressure=" + additionalBackPressure
                    + ", inletFlow=" + inletFlow + ", fixDepth=" + fixDepth + ", fixPointDownDeep=" + fixPointDownDeep
                    + ", fixPointPressure=" + fixPointPressure + ", wellMouthAdjustment=" + wellMouthAdjustment
                    + ", fixPointPressureLoss=" + fixPointPressureLoss + ", boDongYL=" + boDongYL + ", yaHaoXZ=" + yaHaoXZ
                    + ", qiXiaZuanSD=" + qiXiaZuanSD + ", qiXiaZuanJSD=" + qiXiaZuanJSD + ", fixPointECD=" + fixPointECD
                    + ", drillECD=" + drillECD + ", drillStringPressureDrop=" + drillStringPressureDrop
                    + ", drillBitPressureDrop=" + drillBitPressureDrop + ", environmentalControlPressureLoss="
                    + environmentalControlPressureLoss + ", targetBackPressure=" + targetBackPressure
                    + ", hydrostaticPressure=" + hydrostaticPressure + ", state_1=" + state_1 + ", state_2=" + state_2
                    + "]";
        }
        

        private String dateTime;
        private Double time;
        /**井深(m),所属表字段为 oil_2.WellDep  */
        private Double wellDep;
        /**垂深(m),所属表字段为 oil_2.HangDownDeep  */
        private Double hangDownDeep;
        /**钻头深度(m),所属表字段为 oil_2.DepthOfTheDrillBit  */
        private Double depthOfTheDrillBit;
        /**钻头垂深(m),所属表字段为 oil_2.DrillDownDeep  */
        private Double drillDownDeep;
        /**钻时(min/m),所属表字段为 oil_2.DrillingTime  */
        private Double drillingTime;
        /**钻压(KN),所属表字段为 oil_2.BitPressure  */
        private Double bitPressure;
        /**悬重(KN),所属表字段为 oil_2.HangingLoad  */
        private Double hangingLoad;
        /**转速(rpm),所属表字段为 oil_2.RotationRate  */
        private Double rotationRate;
        /**扭矩(KN.m),所属表字段为 oil_2.Torque  */
        private Double torque;
        /**方入(m),所属表字段为 oil_2.KellyDown  */
        private Double kellyDown;
        /**大钩位置(m),所属表字段为 oil_2.HookPosition  */
        private Double hookPosition;
        /**大钩速度(m/s),所属表字段为 oil_2.HookSpeed  */
        private Double hookSpeed;
        /**立压log(MPa),所属表字段为 oil_2.StandpipePressurelog  */
        private Double standpipePressurelog;
        /**套压(MPa),所属表字段为 oil_2.CasingPressure  */
        private Double casingPressure;
        /**泵冲1(spm),所属表字段为 oil_2.PumpStroke1  */
        private Double pumpStroke1;
        /**泵冲2(spm),所属表字段为 oil_2.PumpStroke2  */
        private Double pumpStroke2;
        /**泵冲3(spm),所属表字段为 oil_2.PumpStroke3  */
        private Double pumpStroke3;
        /**总池体积(m3),所属表字段为 oil_2.TotalPoolSize  */
        private Double totalPoolSize;
        /**迟到时间(min),所属表字段为 oil_2.LayTime  */
        private Double layTime;
        /**泥浆溢漏(m3),所属表字段为 oil_2.MudSpill  */
        private Double mudSpill;
        /**入口流量log(L/s),所属表字段为 oil_2.InletFlowlog  */
        private Double inletFlowlog;
        /**出口流量log(%),所属表字段为 oil_2.OutletFlowlog  */
        private Double outletFlowlog;
        /**入口密度log(g/cc),所属表字段为 oil_2.InletDensitylog  */
        private Double inletDensitylog;
        /**出口密度log(g/cc),所属表字段为 oil_2.OutletDensitylog  */
        private Double outletDensitylog;
        /**入口温度(℃),所属表字段为 oil_2.EntranceTempreture  */
        private Double entranceTempreture;
        /**出口温度(℃),所属表字段为 oil_2.ExitTempreture  */
        private Double exitTempreture;
        /**总烃(%),所属表字段为 oil_2.TotalHydrocarbon  */
        private Double totalHydrocarbon;
        /**H2S(ppm),所属表字段为 oil_2.H2S  */
        private Double h2S;
        /**C1(%),所属表字段为 oil_2.C1  */
        private Double c1;
        /**C2(%),所属表字段为 oil_2.C2  */
        private Double c2;
        /**PWD深度(m),所属表字段为 oil_2.PWDDepth  */
        private Double PWDDepth;
        /**PWD垂深(m),所属表字段为 oil_2.PWDHangDownDeep  */
        private Double PWDHangDownDeep;
        /**PWD钻柱压力(MPa),所属表字段为 oil_2.PWD_zzyl  */
        private Double PWD_zzyl;
        /**PWD环空压力(MPa),所属表字段为 oil_2.PWD_hkyl  */
        private Double PWD_hkyl;
        /**PWD环空温度(℃),所属表字段为 oil_2.PWD_hkwd  */
        private Double PWD_hkwd;
        /**PWD测量ECD(g/cc),所属表字段为 oil_2.PWD_cl_ECD  */
        private Double PWD_cl_ECD;
        /**PWD井斜(°),所属表字段为 oil_2.PWDWellDeviation  */
        private Double PWDWellDeviation;
        /**PWD方位(°),所属表字段为 oil_2.PWDLocation  */
        private Double PWDLocation;
        /**注替体积(m3),所属表字段为 oil_2.qztj  */
        private Double qztj;
        /**上返深度(m),所属表字段为 oil_2.UpturnDepth  */
        private Double upturnDepth;
        /**操作模式,所属表字段为 oil_2.OperatorSchema  */
        private Double operatorSchema;
        /**立压(MPa),所属表字段为 oil_2.StandpipePressure  */
        private Double standpipePressure;
        /**测量回压(MPa),所属表字段为 oil_2.MeasurementOfBackPressure  */
        private Double measurementOfBackPressure;
        /**出口流量(L/s),所属表字段为 oil_2.OutletFlow  */
        private Double outletFlow;
        /**出口密度(g/cc),所属表字段为 oil_2.OutletDensity  */
        private Double outletDensity;
        /**回压泵流量(L/s),所属表字段为 oil_2.BackPressurePumpFlow  */
        private Double backPressurePumpFlow;
        /**循环回压(MPa),所属表字段为 oil_2.LoopBackPressure  */
        private Double loopBackPressure;
        /**附加回压(MPa),所属表字段为 oil_2.AdditionalBackPressure  */
        private Double additionalBackPressure;
        /**入口流量(L/s),所属表字段为 oil_2.InletFlow  */
        private Double inletFlow;
        /**定点深度(m),所属表字段为 oil_2.FixDepth  */
        private Double fixDepth;
        /**定点垂深(m),所属表字段为 oil_2.FixPointDownDeep  */
        private Double fixPointDownDeep;
        /**定点压力(MPa),所属表字段为 oil_2.FixPointPressure  */
        private Double fixPointPressure;
        /**井口调节压力(MPa),所属表字段为 oil_2.WellMouthAdjustment  */
        private Double wellMouthAdjustment;
        /**定点压耗(MPa),所属表字段为 oil_2.FixPointPressureLoss  */
        private Double fixPointPressureLoss;
        /**波动压力(MPa),所属表字段为 oil_2.BoDongYL  */
        private Double boDongYL;
        /**压耗修正(MPa/km),所属表字段为 oil_2.YaHaoXZ  */
        private Double yaHaoXZ;
        /**起下钻速度(m/s),所属表字段为 oil_2.QiXiaZuanSD  */
        private Double qiXiaZuanSD;
        /**起下钻加速度(m/s2),所属表字段为 oil_2.QiXiaZuanJSD  */
        private Double qiXiaZuanJSD;
        /**定点ECD(g/cm2),所属表字段为 oil_2.FixPointECD  */
        private Double fixPointECD;
        /**钻头ECD(g/cc),所属表字段为 oil_2.DrillECD  */
        private Double drillECD;
        /**钻柱压降(MPa),所属表字段为 oil_2.DrillStringPressureDrop  */
        private Double drillStringPressureDrop;
        /**钻头压降(MPa),所属表字段为 oil_2.DrillBitPressureDrop  */
        private Double drillBitPressureDrop;
        /**环空压耗(MPa),所属表字段为 oil_2.EnvironmentalControlPressureLoss  */
        private Double environmentalControlPressureLoss;
        /**目标回压(MPa),所属表字段为 oil_2.TargetBackPressure  */
        private Double targetBackPressure;
        /**静液压力(MPa),所属表字段为 oil_2.HydrostaticPressure  */
        private Double hydrostaticPressure;
        /**工况1,所属表字段为 oil_2.State_1  */
        private Double state_1;
        /**工况2,所属表字段为 oil_2.State_2  */
        private Double state_2;

        /**
         * 获取  字段:oil_2.DateTime
         *
         * @return  oil_2.DateTime
         */
        public String getDateTime()
        {
            return dateTime;
        }

        /**
         * 设置  字段:oil_2.DateTime
         *
         * @param dateTime  oil_2.DateTime
         */
        public void setDateTime(String dateTime)
        {
            this.dateTime = dateTime;// == null ? null : dateTime.trim();
        }

        /**
         * 获取  字段:oil_2.Time
         *
         * @return  oil_2.Time
         */
        public Double getTime()
        {
            return time;
        }

        /**
         * 设置  字段:oil_2.Time
         *
         * @param time  oil_2.Time
         */
        public void setTime(Double time)
        {
            this.time = time;
        }

        /**
         * 获取 井深(m) 字段:oil_2.WellDep
         *
         * @return  oil_2.WellDep  ,井深(m)
         */
        public Double getWellDep()
        {
            return wellDep;
        }

        /**
         * 设置 井深(m) 字段:oil_2.WellDep
         *
         * @param wellDep  oil_2.WellDep,井深(m)
         */
        public void setWellDep(Double wellDep)
        {
            this.wellDep = wellDep;
        }

        /**
         * 获取 垂深(m) 字段:oil_2.HangDownDeep
         *
         * @return  oil_2.HangDownDeep  ,垂深(m)
         */
        public Double getHangDownDeep()
        {
            return hangDownDeep;
        }

        /**
         * 设置 垂深(m) 字段:oil_2.HangDownDeep
         *
         * @param hangDownDeep  oil_2.HangDownDeep,垂深(m)
         */
        public void setHangDownDeep(Double hangDownDeep)
        {
            this.hangDownDeep = hangDownDeep;
        }

        /**
         * 获取 钻头深度(m) 字段:oil_2.DepthOfTheDrillBit
         *
         * @return  oil_2.DepthOfTheDrillBit  ,钻头深度(m)
         */
        public Double getDepthOfTheDrillBit()
        {
            return depthOfTheDrillBit;
        }

        /**
         * 设置 钻头深度(m) 字段:oil_2.DepthOfTheDrillBit
         *
         * @param depthOfTheDrillBit  oil_2.DepthOfTheDrillBit,钻头深度(m)
         */
        public void setDepthOfTheDrillBit(Double depthOfTheDrillBit)
        {
            this.depthOfTheDrillBit = depthOfTheDrillBit;
        }

        /**
         * 获取 钻头垂深(m) 字段:oil_2.DrillDownDeep
         *
         * @return  oil_2.DrillDownDeep  ,钻头垂深(m)
         */
        public Double getDrillDownDeep()
        {
            return drillDownDeep;
        }

        /**
         * 设置 钻头垂深(m) 字段:oil_2.DrillDownDeep
         *
         * @param drillDownDeep  oil_2.DrillDownDeep,钻头垂深(m)
         */
        public void setDrillDownDeep(Double drillDownDeep)
        {
            this.drillDownDeep = drillDownDeep;
        }

        /**
         * 获取 钻时(min/m) 字段:oil_2.DrillingTime
         *
         * @return  oil_2.DrillingTime  ,钻时(min/m)
         */
        public Double getDrillingTime()
        {
            return drillingTime;
        }

        /**
         * 设置 钻时(min/m) 字段:oil_2.DrillingTime
         *
         * @param drillingTime  oil_2.DrillingTime,钻时(min/m)
         */
        public void setDrillingTime(Double drillingTime)
        {
            this.drillingTime = drillingTime;
        }

        /**
         * 获取 钻压(KN) 字段:oil_2.BitPressure
         *
         * @return  oil_2.BitPressure  ,钻压(KN)
         */
        public Double getBitPressure()
        {
            return bitPressure;
        }

        /**
         * 设置 钻压(KN) 字段:oil_2.BitPressure
         *
         * @param bitPressure  oil_2.BitPressure,钻压(KN)
         */
        public void setBitPressure(Double bitPressure)
        {
            this.bitPressure = bitPressure;
        }

        /**
         * 获取 悬重(KN) 字段:oil_2.HangingLoad
         *
         * @return  oil_2.HangingLoad  ,悬重(KN)
         */
        public Double getHangingLoad()
        {
            return hangingLoad;
        }

        /**
         * 设置 悬重(KN) 字段:oil_2.HangingLoad
         *
         * @param hangingLoad  oil_2.HangingLoad,悬重(KN)
         */
        public void setHangingLoad(Double hangingLoad)
        {
            this.hangingLoad = hangingLoad;
        }

        /**
         * 获取 转速(rpm) 字段:oil_2.RotationRate
         *
         * @return  oil_2.RotationRate  ,转速(rpm)
         */
        public Double getRotationRate()
        {
            return rotationRate;
        }

        /**
         * 设置 转速(rpm) 字段:oil_2.RotationRate
         *
         * @param rotationRate  oil_2.RotationRate,转速(rpm)
         */
        public void setRotationRate(Double rotationRate)
        {
            this.rotationRate = rotationRate;
        }

        /**
         * 获取 扭矩(KN.m) 字段:oil_2.Torque
         *
         * @return  oil_2.Torque  ,扭矩(KN.m)
         */
        public Double getTorque()
        {
            return torque;
        }

        /**
         * 设置 扭矩(KN.m) 字段:oil_2.Torque
         *
         * @param torque  oil_2.Torque,扭矩(KN.m)
         */
        public void setTorque(Double torque)
        {
            this.torque = torque;
        }

        /**
         * 获取 方入(m) 字段:oil_2.KellyDown
         *
         * @return  oil_2.KellyDown  ,方入(m)
         */
        public Double getKellyDown()
        {
            return kellyDown;
        }

        /**
         * 设置 方入(m) 字段:oil_2.KellyDown
         *
         * @param kellyDown  oil_2.KellyDown,方入(m)
         */
        public void setKellyDown(Double kellyDown)
        {
            this.kellyDown = kellyDown;
        }

        /**
         * 获取 大钩位置(m) 字段:oil_2.HookPosition
         *
         * @return  oil_2.HookPosition  ,大钩位置(m)
         */
        public Double getHookPosition()
        {
            return hookPosition;
        }

        /**
         * 设置 大钩位置(m) 字段:oil_2.HookPosition
         *
         * @param hookPosition  oil_2.HookPosition,大钩位置(m)
         */
        public void setHookPosition(Double hookPosition)
        {
            this.hookPosition = hookPosition;
        }

        /**
         * 获取 大钩速度(m/s) 字段:oil_2.HookSpeed
         *
         * @return  oil_2.HookSpeed  ,大钩速度(m/s)
         */
        public Double getHookSpeed()
        {
            return hookSpeed;
        }

        /**
         * 设置 大钩速度(m/s) 字段:oil_2.HookSpeed
         *
         * @param hookSpeed  oil_2.HookSpeed,大钩速度(m/s)
         */
        public void setHookSpeed(Double hookSpeed)
        {
            this.hookSpeed = hookSpeed;
        }

        /**
         * 获取 立压log(MPa) 字段:oil_2.StandpipePressurelog
         *
         * @return  oil_2.StandpipePressurelog  ,立压log(MPa)
         */
        public Double getStandpipePressurelog()
        {
            return standpipePressurelog;
        }

        /**
         * 设置 立压log(MPa) 字段:oil_2.StandpipePressurelog
         *
         * @param standpipePressurelog  oil_2.StandpipePressurelog,立压log(MPa)
         */
        public void setStandpipePressurelog(Double standpipePressurelog)
        {
            this.standpipePressurelog = standpipePressurelog;
        }

        /**
         * 获取 套压(MPa) 字段:oil_2.CasingPressure
         *
         * @return  oil_2.CasingPressure  ,套压(MPa)
         */
        public Double getCasingPressure()
        {
            return casingPressure;
        }

        /**
         * 设置 套压(MPa) 字段:oil_2.CasingPressure
         *
         * @param casingPressure  oil_2.CasingPressure,套压(MPa)
         */
        public void setCasingPressure(Double casingPressure)
        {
            this.casingPressure = casingPressure;
        }

        /**
         * 获取 泵冲1(spm) 字段:oil_2.PumpStroke1
         *
         * @return  oil_2.PumpStroke1  ,泵冲1(spm)
         */
        public Double getPumpStroke1()
        {
            return pumpStroke1;
        }

        /**
         * 设置 泵冲1(spm) 字段:oil_2.PumpStroke1
         *
         * @param pumpStroke1  oil_2.PumpStroke1,泵冲1(spm)
         */
        public void setPumpStroke1(Double pumpStroke1)
        {
            this.pumpStroke1 = pumpStroke1;
        }

        /**
         * 获取 泵冲2(spm) 字段:oil_2.PumpStroke2
         *
         * @return  oil_2.PumpStroke2  ,泵冲2(spm)
         */
        public Double getPumpStroke2()
        {
            return pumpStroke2;
        }

        /**
         * 设置 泵冲2(spm) 字段:oil_2.PumpStroke2
         *
         * @param pumpStroke2  oil_2.PumpStroke2,泵冲2(spm)
         */
        public void setPumpStroke2(Double pumpStroke2)
        {
            this.pumpStroke2 = pumpStroke2;
        }

        /**
         * 获取 泵冲3(spm) 字段:oil_2.PumpStroke3
         *
         * @return  oil_2.PumpStroke3  ,泵冲3(spm)
         */
        public Double getPumpStroke3()
        {
            return pumpStroke3;
        }

        /**
         * 设置 泵冲3(spm) 字段:oil_2.PumpStroke3
         *
         * @param pumpStroke3  oil_2.PumpStroke3,泵冲3(spm)
         */
        public void setPumpStroke3(Double pumpStroke3)
        {
            this.pumpStroke3 = pumpStroke3;
        }

        /**
         * 获取 总池体积(m3) 字段:oil_2.TotalPoolSize
         *
         * @return  oil_2.TotalPoolSize  ,总池体积(m3)
         */
        public Double getTotalPoolSize()
        {
            return totalPoolSize;
        }

        /**
         * 设置 总池体积(m3) 字段:oil_2.TotalPoolSize
         *
         * @param totalPoolSize  oil_2.TotalPoolSize,总池体积(m3)
         */
        public void setTotalPoolSize(Double totalPoolSize)
        {
            this.totalPoolSize = totalPoolSize;
        }

        /**
         * 获取 迟到时间(min) 字段:oil_2.LayTime
         *
         * @return  oil_2.LayTime  ,迟到时间(min)
         */
        public Double getLayTime()
        {
            return layTime;
        }

        /**
         * 设置 迟到时间(min) 字段:oil_2.LayTime
         *
         * @param layTime  oil_2.LayTime,迟到时间(min)
         */
        public void setLayTime(Double layTime)
        {
            this.layTime = layTime;
        }

        /**
         * 获取 泥浆溢漏(m3) 字段:oil_2.MudSpill
         *
         * @return  oil_2.MudSpill  ,泥浆溢漏(m3)
         */
        public Double getMudSpill()
        {
            return mudSpill;
        }

        /**
         * 设置 泥浆溢漏(m3) 字段:oil_2.MudSpill
         *
         * @param mudSpill  oil_2.MudSpill,泥浆溢漏(m3)
         */
        public void setMudSpill(Double mudSpill)
        {
            this.mudSpill = mudSpill;
        }

        /**
         * 获取 入口流量log(L/s) 字段:oil_2.InletFlowlog
         *
         * @return  oil_2.InletFlowlog  ,入口流量log(L/s)
         */
        public Double getInletFlowlog()
        {
            return inletFlowlog;
        }

        /**
         * 设置 入口流量log(L/s) 字段:oil_2.InletFlowlog
         *
         * @param inletFlowlog  oil_2.InletFlowlog,入口流量log(L/s)
         */
        public void setInletFlowlog(Double inletFlowlog)
        {
            this.inletFlowlog = inletFlowlog;
        }

        /**
         * 获取 出口流量log(%) 字段:oil_2.OutletFlowlog
         *
         * @return  oil_2.OutletFlowlog  ,出口流量log(%)
         */
        public Double getOutletFlowlog()
        {
            return outletFlowlog;
        }

        /**
         * 设置 出口流量log(%) 字段:oil_2.OutletFlowlog
         *
         * @param outletFlowlog  oil_2.OutletFlowlog,出口流量log(%)
         */
        public void setOutletFlowlog(Double outletFlowlog)
        {
            this.outletFlowlog = outletFlowlog;
        }

        /**
         * 获取 入口密度log(g/cc) 字段:oil_2.InletDensitylog
         *
         * @return  oil_2.InletDensitylog  ,入口密度log(g/cc)
         */
        public Double getInletDensitylog()
        {
            return inletDensitylog;
        }

        /**
         * 设置 入口密度log(g/cc) 字段:oil_2.InletDensitylog
         *
         * @param inletDensitylog  oil_2.InletDensitylog,入口密度log(g/cc)
         */
        public void setInletDensitylog(Double inletDensitylog)
        {
            this.inletDensitylog = inletDensitylog;
        }

        /**
         * 获取 出口密度log(g/cc) 字段:oil_2.OutletDensitylog
         *
         * @return  oil_2.OutletDensitylog  ,出口密度log(g/cc)
         */
        public Double getOutletDensitylog()
        {
            return outletDensitylog;
        }

        /**
         * 设置 出口密度log(g/cc) 字段:oil_2.OutletDensitylog
         *
         * @param outletDensitylog  oil_2.OutletDensitylog,出口密度log(g/cc)
         */
        public void setOutletDensitylog(Double outletDensitylog)
        {
            this.outletDensitylog = outletDensitylog;
        }

        /**
         * 获取 入口温度(℃) 字段:oil_2.EntranceTempreture
         *
         * @return  oil_2.EntranceTempreture  ,入口温度(℃)
         */
        public Double getEntranceTempreture()
        {
            return entranceTempreture;
        }

        /**
         * 设置 入口温度(℃) 字段:oil_2.EntranceTempreture
         *
         * @param entranceTempreture  oil_2.EntranceTempreture,入口温度(℃)
         */
        public void setEntranceTempreture(Double entranceTempreture)
        {
            this.entranceTempreture = entranceTempreture;
        }

        /**
         * 获取 出口温度(℃) 字段:oil_2.ExitTempreture
         *
         * @return  oil_2.ExitTempreture  ,出口温度(℃)
         */
        public Double getExitTempreture()
        {
            return exitTempreture;
        }

        /**
         * 设置 出口温度(℃) 字段:oil_2.ExitTempreture
         *
         * @param exitTempreture  oil_2.ExitTempreture,出口温度(℃)
         */
        public void setExitTempreture(Double exitTempreture)
        {
            this.exitTempreture = exitTempreture;
        }

        /**
         * 获取 总烃(%) 字段:oil_2.TotalHydrocarbon
         *
         * @return  oil_2.TotalHydrocarbon  ,总烃(%)
         */
        public Double getTotalHydrocarbon()
        {
            return totalHydrocarbon;
        }

        /**
         * 设置 总烃(%) 字段:oil_2.TotalHydrocarbon
         *
         * @param totalHydrocarbon  oil_2.TotalHydrocarbon,总烃(%)
         */
        public void setTotalHydrocarbon(Double totalHydrocarbon)
        {
            this.totalHydrocarbon = totalHydrocarbon;
        }

        /**
         * 获取 H2S(ppm) 字段:oil_2.H2S
         *
         * @return  oil_2.H2S  ,H2S(ppm)
         */
        public Double getH2S()
        {
            return h2S;
        }

        /**
         * 设置 H2S(ppm) 字段:oil_2.H2S
         *
         * @param h2S  oil_2.H2S,H2S(ppm)
         */
        public void setH2S(Double h2S)
        {
            this.h2S = h2S;
        }

        /**
         * 获取 C1(%) 字段:oil_2.C1
         *
         * @return  oil_2.C1  ,C1(%)
         */
        public Double getC1()
        {
            return c1;
        }

        /**
         * 设置 C1(%) 字段:oil_2.C1
         *
         * @param c1  oil_2.C1,C1(%)
         */
        public void setC1(Double c1)
        {
            this.c1 = c1;
        }

        /**
         * 获取 C2(%) 字段:oil_2.C2
         *
         * @return  oil_2.C2  ,C2(%)
         */
        public Double getC2()
        {
            return c2;
        }

        /**
         * 设置 C2(%) 字段:oil_2.C2
         *
         * @param c2  oil_2.C2,C2(%)
         */
        public void setC2(Double c2)
        {
            this.c2 = c2;
        }

        /**
         * 获取 PWD深度(m) 字段:oil_2.PWDDepth
         *
         * @return  oil_2.PWDDepth  ,PWD深度(m)
         */
        public Double getPWDDepth()
        {
            return PWDDepth;
        }

        /**
         * 设置 PWD深度(m) 字段:oil_2.PWDDepth
         *
         * @param PWDDepth  oil_2.PWDDepth,PWD深度(m)
         */
        public void setPWDDepth(Double PWDDepth)
        {
            this.PWDDepth = PWDDepth;
        }

        /**
         * 获取 PWD垂深(m) 字段:oil_2.PWDHangDownDeep
         *
         * @return  oil_2.PWDHangDownDeep  ,PWD垂深(m)
         */
        public Double getPWDHangDownDeep()
        {
            return PWDHangDownDeep;
        }

        /**
         * 设置 PWD垂深(m) 字段:oil_2.PWDHangDownDeep
         *
         * @param PWDHangDownDeep  oil_2.PWDHangDownDeep,PWD垂深(m)
         */
        public void setPWDHangDownDeep(Double PWDHangDownDeep)
        {
            this.PWDHangDownDeep = PWDHangDownDeep;
        }

        /**
         * 获取 PWD钻柱压力(MPa) 字段:oil_2.PWD_zzyl
         *
         * @return  oil_2.PWD_zzyl  ,PWD钻柱压力(MPa)
         */
        public Double getPWD_zzyl()
        {
            return PWD_zzyl;
        }

        /**
         * 设置 PWD钻柱压力(MPa) 字段:oil_2.PWD_zzyl
         *
         * @param PWD_zzyl  oil_2.PWD_zzyl,PWD钻柱压力(MPa)
         */
        public void setPWD_zzyl(Double PWD_zzyl)
        {
            this.PWD_zzyl = PWD_zzyl;
        }

        /**
         * 获取 PWD环空压力(MPa) 字段:oil_2.PWD_hkyl
         *
         * @return  oil_2.PWD_hkyl  ,PWD环空压力(MPa)
         */
        public Double getPWD_hkyl()
        {
            return PWD_hkyl;
        }

        /**
         * 设置 PWD环空压力(MPa) 字段:oil_2.PWD_hkyl
         *
         * @param PWD_hkyl  oil_2.PWD_hkyl,PWD环空压力(MPa)
         */
        public void setPWD_hkyl(Double PWD_hkyl)
        {
            this.PWD_hkyl = PWD_hkyl;
        }

        /**
         * 获取 PWD环空温度(℃) 字段:oil_2.PWD_hkwd
         *
         * @return  oil_2.PWD_hkwd  ,PWD环空温度(℃)
         */
        public Double getPWD_hkwd()
        {
            return PWD_hkwd;
        }

        /**
         * 设置 PWD环空温度(℃) 字段:oil_2.PWD_hkwd
         *
         * @param PWD_hkwd  oil_2.PWD_hkwd,PWD环空温度(℃)
         */
        public void setPWD_hkwd(Double PWD_hkwd)
        {
            this.PWD_hkwd = PWD_hkwd;
        }

        /**
         * 获取 PWD测量ECD(g/cc) 字段:oil_2.PWD_cl_ECD
         *
         * @return  oil_2.PWD_cl_ECD  ,PWD测量ECD(g/cc)
         */
        public Double getPWD_cl_ECD()
        {
            return PWD_cl_ECD;
        }

        /**
         * 设置 PWD测量ECD(g/cc) 字段:oil_2.PWD_cl_ECD
         *
         * @param PWD_cl_ECD  oil_2.PWD_cl_ECD,PWD测量ECD(g/cc)
         */
        public void setPWD_cl_ECD(Double PWD_cl_ECD)
        {
            this.PWD_cl_ECD = PWD_cl_ECD;
        }

        /**
         * 获取 PWD井斜(°) 字段:oil_2.PWDWellDeviation
         *
         * @return  oil_2.PWDWellDeviation  ,PWD井斜(°)
         */
        public Double getPWDWellDeviation()
        {
            return PWDWellDeviation;
        }

        /**
         * 设置 PWD井斜(°) 字段:oil_2.PWDWellDeviation
         *
         * @param PWDWellDeviation  oil_2.PWDWellDeviation,PWD井斜(°)
         */
        public void setPWDWellDeviation(Double PWDWellDeviation)
        {
            this.PWDWellDeviation = PWDWellDeviation;
        }

        /**
         * 获取 PWD方位(°) 字段:oil_2.PWDLocation
         *
         * @return  oil_2.PWDLocation  ,PWD方位(°)
         */
        public Double getPWDLocation()
        {
            return PWDLocation;
        }

        /**
         * 设置 PWD方位(°) 字段:oil_2.PWDLocation
         *
         * @param PWDLocation  oil_2.PWDLocation,PWD方位(°)
         */
        public void setPWDLocation(Double PWDLocation)
        {
            this.PWDLocation = PWDLocation;
        }

        /**
         * 获取 注替体积(m3) 字段:oil_2.qztj
         *
         * @return  oil_2.qztj  ,注替体积(m3)
         */
        public Double getQztj()
        {
            return qztj;
        }

        /**
         * 设置 注替体积(m3) 字段:oil_2.qztj
         *
         * @param qztj  oil_2.qztj,注替体积(m3)
         */
        public void setQztj(Double qztj)
        {
            this.qztj = qztj;
        }

        /**
         * 获取 上返深度(m) 字段:oil_2.UpturnDepth
         *
         * @return  oil_2.UpturnDepth  ,上返深度(m)
         */
        public Double getUpturnDepth()
        {
            return upturnDepth;
        }

        /**
         * 设置 上返深度(m) 字段:oil_2.UpturnDepth
         *
         * @param upturnDepth  oil_2.UpturnDepth,上返深度(m)
         */
        public void setUpturnDepth(Double upturnDepth)
        {
            this.upturnDepth = upturnDepth;
        }

        /**
         * 获取 操作模式 字段:oil_2.OperatorSchema
         *
         * @return  oil_2.OperatorSchema  ,操作模式
         */
        public Double getOperatorSchema()
        {
            return operatorSchema;
        }

        /**
         * 设置 操作模式 字段:oil_2.OperatorSchema
         *
         * @param operatorSchema  oil_2.OperatorSchema,操作模式
         */
        public void setOperatorSchema(Double operatorSchema)
        {
            this.operatorSchema = operatorSchema;
        }

        /**
         * 获取 立压(MPa) 字段:oil_2.StandpipePressure
         *
         * @return  oil_2.StandpipePressure  ,立压(MPa)
         */
        public Double getStandpipePressure()
        {
            return standpipePressure;
        }

        /**
         * 设置 立压(MPa) 字段:oil_2.StandpipePressure
         *
         * @param standpipePressure  oil_2.StandpipePressure,立压(MPa)
         */
        public void setStandpipePressure(Double standpipePressure)
        {
            this.standpipePressure = standpipePressure;
        }

        /**
         * 获取 测量回压(MPa) 字段:oil_2.MeasurementOfBackPressure
         *
         * @return  oil_2.MeasurementOfBackPressure  ,测量回压(MPa)
         */
        public Double getMeasurementOfBackPressure()
        {
            return measurementOfBackPressure;
        }

        /**
         * 设置 测量回压(MPa) 字段:oil_2.MeasurementOfBackPressure
         *
         * @param measurementOfBackPressure  oil_2.MeasurementOfBackPressure,测量回压(MPa)
         */
        public void setMeasurementOfBackPressure(Double measurementOfBackPressure)
        {
            this.measurementOfBackPressure = measurementOfBackPressure;
        }

        /**
         * 获取 出口流量(L/s) 字段:oil_2.OutletFlow
         *
         * @return  oil_2.OutletFlow  ,出口流量(L/s)
         */
        public Double getOutletFlow()
        {
            return outletFlow;
        }

        /**
         * 设置 出口流量(L/s) 字段:oil_2.OutletFlow
         *
         * @param outletFlow  oil_2.OutletFlow,出口流量(L/s)
         */
        public void setOutletFlow(Double outletFlow)
        {
            this.outletFlow = outletFlow;
        }

        /**
         * 获取 出口密度(g/cc) 字段:oil_2.OutletDensity
         *
         * @return  oil_2.OutletDensity  ,出口密度(g/cc)
         */
        public Double getOutletDensity()
        {
            return outletDensity;
        }

        /**
         * 设置 出口密度(g/cc) 字段:oil_2.OutletDensity
         *
         * @param outletDensity  oil_2.OutletDensity,出口密度(g/cc)
         */
        public void setOutletDensity(Double outletDensity)
        {
            this.outletDensity = outletDensity;
        }

        /**
         * 获取 回压泵流量(L/s) 字段:oil_2.BackPressurePumpFlow
         *
         * @return  oil_2.BackPressurePumpFlow  ,回压泵流量(L/s)
         */
        public Double getBackPressurePumpFlow()
        {
            return backPressurePumpFlow;
        }

        /**
         * 设置 回压泵流量(L/s) 字段:oil_2.BackPressurePumpFlow
         *
         * @param backPressurePumpFlow  oil_2.BackPressurePumpFlow,回压泵流量(L/s)
         */
        public void setBackPressurePumpFlow(Double backPressurePumpFlow)
        {
            this.backPressurePumpFlow = backPressurePumpFlow;
        }

        /**
         * 获取 循环回压(MPa) 字段:oil_2.LoopBackPressure
         *
         * @return  oil_2.LoopBackPressure  ,循环回压(MPa)
         */
        public Double getLoopBackPressure()
        {
            return loopBackPressure;
        }

        /**
         * 设置 循环回压(MPa) 字段:oil_2.LoopBackPressure
         *
         * @param loopBackPressure  oil_2.LoopBackPressure,循环回压(MPa)
         */
        public void setLoopBackPressure(Double loopBackPressure)
        {
            this.loopBackPressure = loopBackPressure;
        }

        /**
         * 获取 附加回压(MPa) 字段:oil_2.AdditionalBackPressure
         *
         * @return  oil_2.AdditionalBackPressure  ,附加回压(MPa)
         */
        public Double getAdditionalBackPressure()
        {
            return additionalBackPressure;
        }

        /**
         * 设置 附加回压(MPa) 字段:oil_2.AdditionalBackPressure
         *
         * @param additionalBackPressure  oil_2.AdditionalBackPressure,附加回压(MPa)
         */
        public void setAdditionalBackPressure(Double additionalBackPressure)
        {
            this.additionalBackPressure = additionalBackPressure;
        }

        /**
         * 获取 入口流量(L/s) 字段:oil_2.InletFlow
         *
         * @return  oil_2.InletFlow  ,入口流量(L/s)
         */
        public Double getInletFlow()
        {
            return inletFlow;
        }

        /**
         * 设置 入口流量(L/s) 字段:oil_2.InletFlow
         *
         * @param inletFlow  oil_2.InletFlow,入口流量(L/s)
         */
        public void setInletFlow(Double inletFlow)
        {
            this.inletFlow = inletFlow;
        }

        /**
         * 获取 定点深度(m) 字段:oil_2.FixDepth
         *
         * @return  oil_2.FixDepth  ,定点深度(m)
         */
        public Double getFixDepth()
        {
            return fixDepth;
        }

        /**
         * 设置 定点深度(m) 字段:oil_2.FixDepth
         *
         * @param fixDepth  oil_2.FixDepth,定点深度(m)
         */
        public void setFixDepth(Double fixDepth)
        {
            this.fixDepth = fixDepth;
        }

        /**
         * 获取 定点垂深(m) 字段:oil_2.FixPointDownDeep
         *
         * @return  oil_2.FixPointDownDeep  ,定点垂深(m)
         */
        public Double getFixPointDownDeep()
        {
            return fixPointDownDeep;
        }

        /**
         * 设置 定点垂深(m) 字段:oil_2.FixPointDownDeep
         *
         * @param fixPointDownDeep  oil_2.FixPointDownDeep,定点垂深(m)
         */
        public void setFixPointDownDeep(Double fixPointDownDeep)
        {
            this.fixPointDownDeep = fixPointDownDeep;
        }

        /**
         * 获取 定点压力(MPa) 字段:oil_2.FixPointPressure
         *
         * @return  oil_2.FixPointPressure  ,定点压力(MPa)
         */
        public Double getFixPointPressure()
        {
            return fixPointPressure;
        }

        /**
         * 设置 定点压力(MPa) 字段:oil_2.FixPointPressure
         *
         * @param fixPointPressure  oil_2.FixPointPressure,定点压力(MPa)
         */
        public void setFixPointPressure(Double fixPointPressure)
        {
            this.fixPointPressure = fixPointPressure;
        }

        /**
         * 获取 井口调节压力(MPa) 字段:oil_2.WellMouthAdjustment
         *
         * @return  oil_2.WellMouthAdjustment  ,井口调节压力(MPa)
         */
        public Double getWellMouthAdjustment()
        {
            return wellMouthAdjustment;
        }

        /**
         * 设置 井口调节压力(MPa) 字段:oil_2.WellMouthAdjustment
         *
         * @param wellMouthAdjustment  oil_2.WellMouthAdjustment,井口调节压力(MPa)
         */
        public void setWellMouthAdjustment(Double wellMouthAdjustment)
        {
            this.wellMouthAdjustment = wellMouthAdjustment;
        }

        /**
         * 获取 定点压耗(MPa) 字段:oil_2.FixPointPressureLoss
         *
         * @return  oil_2.FixPointPressureLoss  ,定点压耗(MPa)
         */
        public Double getFixPointPressureLoss()
        {
            return fixPointPressureLoss;
        }

        /**
         * 设置 定点压耗(MPa) 字段:oil_2.FixPointPressureLoss
         *
         * @param fixPointPressureLoss  oil_2.FixPointPressureLoss,定点压耗(MPa)
         */
        public void setFixPointPressureLoss(Double fixPointPressureLoss)
        {
            this.fixPointPressureLoss = fixPointPressureLoss;
        }

        /**
         * 获取 波动压力(MPa) 字段:oil_2.BoDongYL
         *
         * @return  oil_2.BoDongYL  ,波动压力(MPa)
         */
        public Double getBoDongYL()
        {
            return boDongYL;
        }

        /**
         * 设置 波动压力(MPa) 字段:oil_2.BoDongYL
         *
         * @param boDongYL  oil_2.BoDongYL,波动压力(MPa)
         */
        public void setBoDongYL(Double boDongYL)
        {
            this.boDongYL = boDongYL;
        }

        /**
         * 获取 压耗修正(MPa/km) 字段:oil_2.YaHaoXZ
         *
         * @return  oil_2.YaHaoXZ  ,压耗修正(MPa/km)
         */
        public Double getYaHaoXZ()
        {
            return yaHaoXZ;
        }

        /**
         * 设置 压耗修正(MPa/km) 字段:oil_2.YaHaoXZ
         *
         * @param yaHaoXZ  oil_2.YaHaoXZ,压耗修正(MPa/km)
         */
        public void setYaHaoXZ(Double yaHaoXZ)
        {
            this.yaHaoXZ = yaHaoXZ;
        }

        /**
         * 获取 起下钻速度(m/s) 字段:oil_2.QiXiaZuanSD
         *
         * @return  oil_2.QiXiaZuanSD  ,起下钻速度(m/s)
         */
        public Double getQiXiaZuanSD()
        {
            return qiXiaZuanSD;
        }

        /**
         * 设置 起下钻速度(m/s) 字段:oil_2.QiXiaZuanSD
         *
         * @param qiXiaZuanSD  oil_2.QiXiaZuanSD,起下钻速度(m/s)
         */
        public void setQiXiaZuanSD(Double qiXiaZuanSD)
        {
            this.qiXiaZuanSD = qiXiaZuanSD;
        }

        /**
         * 获取 起下钻加速度(m/s2) 字段:oil_2.QiXiaZuanJSD
         *
         * @return  oil_2.QiXiaZuanJSD  ,起下钻加速度(m/s2)
         */
        public Double getQiXiaZuanJSD()
        {
            return qiXiaZuanJSD;
        }

        /**
         * 设置 起下钻加速度(m/s2) 字段:oil_2.QiXiaZuanJSD
         *
         * @param qiXiaZuanJSD  oil_2.QiXiaZuanJSD,起下钻加速度(m/s2)
         */
        public void setQiXiaZuanJSD(Double qiXiaZuanJSD)
        {
            this.qiXiaZuanJSD = qiXiaZuanJSD;
        }

        /**
         * 获取 定点ECD(g/cm2) 字段:oil_2.FixPointECD
         *
         * @return  oil_2.FixPointECD  ,定点ECD(g/cm2)
         */
        public Double getFixPointECD()
        {
            return fixPointECD;
        }

        /**
         * 设置 定点ECD(g/cm2) 字段:oil_2.FixPointECD
         *
         * @param fixPointECD  oil_2.FixPointECD,定点ECD(g/cm2)
         */
        public void setFixPointECD(Double fixPointECD)
        {
            this.fixPointECD = fixPointECD;
        }

        /**
         * 获取 钻头ECD(g/cc) 字段:oil_2.DrillECD
         *
         * @return  oil_2.DrillECD  ,钻头ECD(g/cc)
         */
        public Double getDrillECD()
        {
            return drillECD;
        }

        /**
         * 设置 钻头ECD(g/cc) 字段:oil_2.DrillECD
         *
         * @param drillECD  oil_2.DrillECD,钻头ECD(g/cc)
         */
        public void setDrillECD(Double drillECD)
        {
            this.drillECD = drillECD;
        }

        /**
         * 获取 钻柱压降(MPa) 字段:oil_2.DrillStringPressureDrop
         *
         * @return  oil_2.DrillStringPressureDrop  ,钻柱压降(MPa)
         */
        public Double getDrillStringPressureDrop()
        {
            return drillStringPressureDrop;
        }

        /**
         * 设置 钻柱压降(MPa) 字段:oil_2.DrillStringPressureDrop
         *
         * @param drillStringPressureDrop  oil_2.DrillStringPressureDrop,钻柱压降(MPa)
         */
        public void setDrillStringPressureDrop(Double drillStringPressureDrop)
        {
            this.drillStringPressureDrop = drillStringPressureDrop;
        }

        /**
         * 获取 钻头压降(MPa) 字段:oil_2.DrillBitPressureDrop
         *
         * @return  oil_2.DrillBitPressureDrop  ,钻头压降(MPa)
         */
        public Double getDrillBitPressureDrop()
        {
            return drillBitPressureDrop;
        }

        /**
         * 设置 钻头压降(MPa) 字段:oil_2.DrillBitPressureDrop
         *
         * @param drillBitPressureDrop  oil_2.DrillBitPressureDrop,钻头压降(MPa)
         */
        public void setDrillBitPressureDrop(Double drillBitPressureDrop)
        {
            this.drillBitPressureDrop = drillBitPressureDrop;
        }

        /**
         * 获取 环空压耗(MPa) 字段:oil_2.EnvironmentalControlPressureLoss
         *
         * @return  oil_2.EnvironmentalControlPressureLoss  ,环空压耗(MPa)
         */
        public Double getEnvironmentalControlPressureLoss()
        {
            return environmentalControlPressureLoss;
        }

        /**
         * 设置 环空压耗(MPa) 字段:oil_2.EnvironmentalControlPressureLoss
         *
         * @param environmentalControlPressureLoss  oil_2.EnvironmentalControlPressureLoss,环空压耗(MPa)
         */
        public void setEnvironmentalControlPressureLoss(Double environmentalControlPressureLoss)
        {
            this.environmentalControlPressureLoss = environmentalControlPressureLoss;
        }

        /**
         * 获取 目标回压(MPa) 字段:oil_2.TargetBackPressure
         *
         * @return  oil_2.TargetBackPressure  ,目标回压(MPa)
         */
        public Double getTargetBackPressure()
        {
            return targetBackPressure;
        }

        /**
         * 设置 目标回压(MPa) 字段:oil_2.TargetBackPressure
         *
         * @param targetBackPressure  oil_2.TargetBackPressure,目标回压(MPa)
         */
        public void setTargetBackPressure(Double targetBackPressure)
        {
            this.targetBackPressure = targetBackPressure;
        }

        /**
         * 获取 静液压力(MPa) 字段:oil_2.HydrostaticPressure
         *
         * @return  oil_2.HydrostaticPressure  ,静液压力(MPa)
         */
        public Double getHydrostaticPressure()
        {
            return hydrostaticPressure;
        }

        /**
         * 设置 静液压力(MPa) 字段:oil_2.HydrostaticPressure
         *
         * @param hydrostaticPressure  oil_2.HydrostaticPressure,静液压力(MPa)
         */
        public void setHydrostaticPressure(Double hydrostaticPressure)
        {
            this.hydrostaticPressure = hydrostaticPressure;
        }

        /**
         * 获取 工况1 字段:oil_2.State_1
         *
         * @return  oil_2.State_1  ,工况1
         */
        public Double getState_1()
        {
            return state_1;
        }

        /**
         * 设置 工况1 字段:oil_2.State_1
         *
         * @param state_1  oil_2.State_1,工况1
         */
        public void setState_1(Double state_1)
        {
            this.state_1 = state_1;
        }

        /**
         * 获取 工况2 字段:oil_2.State_2
         *
         * @return  oil_2.State_2  ,工况2
         */
        public Double getState_2()
        {
            return state_2;
        }

        /**
         * 设置 工况2 字段:oil_2.State_2
         *
         * @param state_2  oil_2.State_2,工况2
         */
        public void setState_2(Double state_2)
        {
            this.state_2 = state_2;
        }
    }
}
