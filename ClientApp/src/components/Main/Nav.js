/* eslint-disable jsx-a11y/click-events-have-key-events */
export default ({ mainCallback }) => (
  <div
    style={{ display: `block`,
      width: `100%`,
      margin: `auto`,
      textAlign: `center` }}
  >
    {/* <span>Estimates</span> */}
    <span
      onClick={() => mainCallback(0)}
      role='button'
      tabIndex={0}
      style={{ fontWeight: `bold`,
        fontSize: `1.5em`,
        margin: `5px`,
        padding: `10px`,
        border: `1px`,
        borderRadius: `15px`,
        borderStyle: `solid`,
        backgroundColor: `#87ceff` }}
    >Electricity</span>
    <span
      onClick={() => mainCallback(1)}
      role='button'
      tabIndex={0}
      style={{ fontWeight: `bold`,
        fontSize: `1.5em`,
        margin: `5px`,
        padding: `10px`,
        border: `1px`,
        borderRadius: `15px`,
        borderStyle: `solid`,
        backgroundColor: `#87ceff` }}
    >Flight</span>
    <span
      onClick={() => mainCallback(2)}
      role='button'
      tabIndex={0}
      style={{ fontWeight: `bold`,
        fontSize: `1.5em`,
        margin: `5px`,
        padding: `10px`,
        border: `1px`,
        borderRadius: `15px`,
        borderStyle: `solid`,
        backgroundColor: `#87ceff` }}
    >Shipping</span>
    <span
      onClick={() => mainCallback(3)}
      role='button'
      tabIndex={0}
      style={{ fontWeight: `bold`,
        fontSize: `1.5em`,
        margin: `5px`,
        padding: `10px`,
        border: `1px`,
        borderRadius: `15px`,
        borderStyle: `solid`,
        backgroundColor: `#87ceff` }}
    >Vehicle</span>
    <span
      onClick={() => mainCallback(4)}
      role='button'
      tabIndex={0}
      style={{ fontWeight: `bold`,
        fontSize: `1.5em`,
        margin: `5px`,
        padding: `10px`,
        border: `1px`,
        borderRadius: `15px`,
        borderStyle: `solid`,
        backgroundColor: `#87ceff` }}
    >Fuel Combustion</span>
  </div>
)
