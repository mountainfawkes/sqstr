import Sqstr from './Sqstr'
import CO2Int from './CarbonInterface'
import UPCO2 from './UPCO2'

export default () => (
  <>
    <div style={{
      backgroundColor: `#131217`,
      color: `#A19194`,
      padding: `0 15px`,
    }}
    >
      <Sqstr />
      <CO2Int />
      <UPCO2 />
    </div>
  </>
)
