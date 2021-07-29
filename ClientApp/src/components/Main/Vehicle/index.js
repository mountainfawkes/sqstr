import yugos from '../../../Data/Yugos'

const vehicleEstimateForm = ({ formCallback,
  estimateCallback,
  estimateVisibilityCallback }) => {
  async function handleVehicleInput(event) {
    event.preventDefault()
    const data = {
      type: event.target.type.value,
      distance_unit: event.target.distance_unit.value,
      distance_value: event.target.distance_value.value,
      vehicle_model_id: event.target.vehicle_model_id.value,
    }
    console.log(data)
    await fetch(`http://localhost:5000/api/Attributes`, {
      method: `POST`,
      body: JSON.stringify(data),
      headers: {
        'Content-Type': `application/json`,
      },
    })
      .then(response => response.json())
      .then(data => estimateCallback(data))
      .then(data => console.log(data))

    formCallback(null)
    estimateVisibilityCallback(true)
  }

  const contentStyles = {
    maxWidth: `45vw`,
    margin: `auto`,
    marginTop: `30px`,
    padding: `10px`,
    justifyContent: `center`,
    alignItems: `center`,
    backgroundColor: `#0A090C`,
  }

  const inputStyles = {
    display: `block`,
    margin: `5px`,
  }

  return (
    <div style={contentStyles}>
      <div style={{
        backgroundColor: `#131217`,
        color: `#F5F5F5`,
        padding: `15px`,
        fontFamily: `'Montserrat', sans-serif`,
      }}
      >
        <p>There are only 8 car models in this world, and they're all Yugos.</p>
        <form onSubmit={handleVehicleInput}>
          <input type='hidden' name='type' value='vehicle' />
          <div style={inputStyles}>
            <label htmlFor='distance_unit'>Unit of distance:
              <select
                name='distance_unit'
                style={{ margin: `0 0 0 10px` }}
              >
                <option value='mi'>Miles</option>
                <option value='km'>Kilometers</option>
              </select>
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='distance_value'>Distance traveled:
              <input
                type='number'
                step='0.1'
                min='0.1'
                name='distance_value'
                style={{ margin: `0 0 0 10px` }}
              />
            </label>
          </div>
          <div style={inputStyles}>
            <label htmlFor='vehicle_model_id'>Vehicle make and model:
              <select
                name='vehicle_model_id'
                style={{ margin: `0 0 0 10px` }}
              >
                {yugos.map(yugo =>
                  <option value={yugo.id}>
                    {
              yugo.attributes.year
              } {
              yugo.attributes.vehicle_make
              } {
              yugo.attributes.name
              }
                  </option>)}
              </select>
            </label>
          </div>
          <button type='submit' style={{ marginTop: `10px` }}>Estimate</button>
        </form>
      </div>
    </div>
  )
}

export default vehicleEstimateForm
