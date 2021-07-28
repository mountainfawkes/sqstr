// import Auth from './Auth'
import Elevator from './Elevator'

export default () => (
  <>
    <div
      style={{
        display: `flex`,
        order: `0`,
        padding: `10px`,
        justifyContent: `center`,
        alignItems: `center`,
        color: `#0A090C`,
        borderRadius: `15px`,
        zIndex: `100`,
        textAlign: `center`,
        textShadow: `1px 1px 10px #F5F5F5`,
        backdropFilter: `contrast(70%)`,
      }}
    >
      <Elevator />
    </div>
    {/* <div style={{
      display: `flex`,
      order: `1`,
      justifyContent: `center`,
      alignItems: `center`,
    }}
    >
      <Auth />
    </div> */}
  </>
)
